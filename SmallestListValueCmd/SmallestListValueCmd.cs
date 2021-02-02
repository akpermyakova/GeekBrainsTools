#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать метод, возвращающий минимальное из трех чисел.

*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestListValue
{
    class SmallestListValueCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            var thirdValue = double.Parse(Console.ReadLine());

            var minValue = GetSmallestListValue(firstValue, secondValue, thirdValue);

            Console.WriteLine($"Наименьшее значение: {minValue}");
            Console.ReadKey();
        }

        static double GetSmallestListValue(double firstValue, double secondValue, double thirdValue)
        {
            var values = new List<double>() { firstValue, secondValue, thirdValue };
            var minValue = values.Min();
            return minValue;
        }
    }
}
