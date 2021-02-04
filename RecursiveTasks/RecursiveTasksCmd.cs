#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
*Разработать рекурсивный метод, который считает сумму чисел от a до b.

*/
#endregion

//#define list
#define sumList

using System;

namespace RecursiveTasks
{
    class RecursiveTasksCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a:");
            var a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            var b = int.Parse(Console.ReadLine());

            #if list
            CreateList(a, b);

            #elif sumList
            SumList(a, b);

            #else
            Console.WriteLine("Директива не определена. Укажите директиву");

            #endif
            Console.ReadKey();

        }

        static void CreateList(int a, int b)
        {
            if (a <= b)
            {
                Console.Write($"{a}, ");
                a++;
                if (a != b) CreateList(a, b);
                else Console.Write(a);
            }
        }

        static void SumList(int a, int b, int sum = 0)
        {
            if (a <= b)
            {
                sum += a;
                a++;
                SumList(a, b);
            }
            else Console.Write($"Сумма чисел равна {sum}");
        }
    }
}
