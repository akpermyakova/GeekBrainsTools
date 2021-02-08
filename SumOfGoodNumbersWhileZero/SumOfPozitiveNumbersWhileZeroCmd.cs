#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

*/
#endregion

#define Exception
//#define WithoutException

using System;

namespace SumOfPozitiveNumbersWhileZero
{
    class SumOfPozitiveNumbersWhileZeroCmd
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var line = String.Empty;

            while (true)
            {

#if Exception
                int number = CheckValue();

#elif WithoutException
                int number = EnterValue();

#endif
                if (number == 0) break;
                else if (number % 2 != 0 && number > 0)
                {
                    sum += number;
                    line = ($"{line} {number}").TrimStart();
                }
            }
            Console.WriteLine($"Сумма нечетных положительных чисел {line} - равна - {sum}");
            Console.ReadKey();
        }

        static int EnterValue()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int result)) Console.WriteLine("Неверный формат данных");
                else return result;
            }
        }

        static int CheckValue()
        {
            int result = 0;
            bool exception;

            do
            {
                exception = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    exception = true;
                    string message = e.Message;
                    Console.WriteLine("Вызвало исключение: " + message);
                }
            }
            while (exception);

            return result;
        }
    }
}
