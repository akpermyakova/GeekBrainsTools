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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var count = GetCountOfGoodNumbers(startValue, endValue);

            Console.WriteLine(count);
            Console.ReadKey();

        }

        static int GetCountOfGoodNumbers(int startValue, int endValue)
        {
            var count = 0;
            var list = Enumerable.Range(startValue, endValue - startValue);
            
            foreach(var i in list)
            {
                var sum = 0;
                var stringValue = i.ToString();
                foreach(char c in stringValue)
                {
                    sum += int.Parse(c.ToString());
                }

                if (i % sum == 0) count++;
            }

            return count;
        }
    }
}
