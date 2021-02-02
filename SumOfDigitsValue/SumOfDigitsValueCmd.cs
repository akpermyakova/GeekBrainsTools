#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать метод подсчета количества цифр числа.

*/
#endregion

using System;

namespace SumOfDigitsValue
{
    class SumOfDigitsValueCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            var value = int.Parse(Console.ReadLine());

            var sumValue = GetSumOfDigitsValue(value);
            Console.WriteLine($"Сумма цифр числа {value} составляет {sumValue}");
            Console.ReadKey();

        }

        static int GetSumOfDigitsValue(int value)
        {
            if (value == 0) return 0;
            else return GetSumOfDigitsValue(value / 10) + value % 10;
        }
    }
}
