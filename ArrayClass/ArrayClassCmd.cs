#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

2. а) Дописать класс для работы с одномерным массивом.
Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi,
умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
В Main продемонстрировать работу класса.
б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

*/
#endregion

using System;

namespace ArrayClass
{
    class ArrayClassCmd
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер массива:");
                var count = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите стартовое значение:");
                var startValue = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите шаг значений:");
                var step = int.Parse(Console.ReadLine());

                var myArray = new MyArray(count, startValue, step);
                var array = myArray.CreateArray();

                Console.Write("Текущий массив:");
                Console.WriteLine();

                foreach(var mass in array)
                {
                    Console.Write(mass + " ");
                }

                var sum = array;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


        }
    }

    class MyArray
    {
        int Count;
        int StartValue;
        int Step;

        public MyArray(int count, int startValue, int step)
        {
            Count = count;
            StartValue = startValue;
            Step = step;
        }

        public int[] CreateArray()
        {
            var massive = new int[Count];
            var value = StartValue;
            for (var i = 0; i < Count; i++)
            {
                if (i == 0) massive[i] = StartValue;
                else
                {
                    value += Step;
                    massive[i] = value;
                }
            }
            return massive;
        }
    }
}
