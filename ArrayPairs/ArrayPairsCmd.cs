#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
В данной задаче под парой подразумевается два подряд идущих элемента массива.
Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

*/
#endregion

using System;

namespace ArrayPairs
{
    class ArrayPairsCmd
    {
        static void Main(string[] args)
        {
            var massive = new int[20];
            var random = new Random();
            var pairCount = 0;

            for (int i = 0; i < 20; i++)
            {
                massive[i] = random.Next(-10000, 10001);
            }
            
            for(int i = 0; i<20; i++)
            {
                if (i != 19)
                {
                    if (massive[i] % 3 == 0 || massive[i + 1] % 3 == 0) pairCount++;
                }
                else break;
                
            }

            Console.Write("В массиве:");
            Console.WriteLine();

            foreach (var mass in massive)
            {
                if (GetSumOfDigits(mass) % 3 == 0) Console.Write($"{mass}({true}) ");
                else Console.Write($"{mass}({false}) ");
            }

            Console.WriteLine();
            Console.Write($"{pairCount} пар чисел, в которых хотя бы одно значение кратно 3");
            
            Console.ReadKey();
        }

        static int GetSumOfDigits(int value)
        {
            if (value == 0) return 0;
            else return GetSumOfDigits(value / 10) + value % 10;
        }
    }
}
