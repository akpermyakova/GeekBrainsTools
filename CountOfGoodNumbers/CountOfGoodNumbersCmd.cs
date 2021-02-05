#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
Хорошим называется число, которое делится на сумму своих цифр.
Реализовать подсчет времени выполнения программы, используя структуру DateTime.

*/
#endregion

using System;

namespace CountOfGoodNumbers
{
    class CountOfGoodNumbersCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение диапазона:");
            var startValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение диапазона:");
            var endValue = int.Parse(Console.ReadLine());

            DateTime start = DateTime.Now;

            var count = GetCountOfGoodNumbers(startValue, endValue);

            Console.WriteLine($"В диапазоне от {startValue} до {endValue} - {count} 'хороших' чисел");

            DateTime finish = DateTime.Now;
            Console.WriteLine($"На выполнение команды затрачено {finish - start}");

            Console.ReadKey();
        }

        static int GetCountOfGoodNumbers(int startValue, int endValue)
        {
            var count = 0;
            for(var i = startValue;  i<=endValue; i++)
            {
                var sum = GetSumOfDigitsValue(i);
                if (i % sum == 0) count++;
            }
            return count;
        }

        static int GetSumOfDigitsValue(int value)
        {
            if (value == 0) return 0;
            else return GetSumOfDigitsValue(value / 10) + value % 10;
        }
    }
}
