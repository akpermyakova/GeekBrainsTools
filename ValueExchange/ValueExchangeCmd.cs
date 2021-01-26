#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу обмена значениями двух переменных.

*/
#endregion

//#define Три
#define Два

using System;

namespace ValueExchange
{
    class ValueExchangeCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            if (double.TryParse(Console.ReadLine(), out var firstValue));
            else Console.WriteLine("Вы ввели текст");

            Console.WriteLine("Введите второе число:");
            if (double.TryParse(Console.ReadLine(), out var secondValue)) ;
            else Console.WriteLine("Вы ввели текст");

#if Три
            var tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
            var line = $"Значения поменялись местами: {firstValue}, {secondValue}";

#elif Два
            firstValue = firstValue + secondValue;
            secondValue = secondValue - firstValue;
            secondValue = -secondValue;
            firstValue = firstValue - secondValue;
            var line = $"Значения поменялись местами: {firstValue}, {secondValue}";

#else
            var line = "Не указана директива. Для дальнейшей работы укажите директиву."; 

#endif
            Console.Write(line);
            Console.ReadKey();
        }
    }
}
