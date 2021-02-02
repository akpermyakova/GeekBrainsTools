#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

С клавиатуры вводятся числа, пока не будет введен 0.
Подсчитать сумму всех нечетных положительных чисел.

*/
#endregion

using System;

namespace SumOfOddPositiveNumbers
{
    class SumOfOddPositiveNumbersCmd
    {
        static void Main(string[] args)
        {
            int value, sum = 0;
            
            do
            {
                Console.WriteLine("Введите число:");
                value = int.Parse(Console.ReadLine());
                if (value % 2 != 0 && value > 0) sum += value;
            }
            
            while (value != 0);

            Console.WriteLine($"Сумма всех нечетных положительных чисел {sum}");
            Console.ReadKey();
        }
    }
}
