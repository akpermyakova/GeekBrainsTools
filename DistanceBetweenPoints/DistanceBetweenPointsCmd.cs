#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f 
(с двумя знаками после запятой).

*/
#endregion

//#define Метод
//#define Команда

using System;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPointsCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1:");
            if (double.TryParse(Console.ReadLine(), out var x1));
            else Console.WriteLine("Вы ввели текст");

            Console.WriteLine("Введите y1:");
            if (double.TryParse(Console.ReadLine(), out var y1));
            else Console.WriteLine("Вы ввели текст");

            Console.WriteLine("Введите x2:");
            if (double.TryParse(Console.ReadLine(), out var x2));
            else Console.WriteLine("Вы ввели текст");

            Console.WriteLine("Введите y2:");
            if (double.TryParse(Console.ReadLine(), out var y2));
            else Console.WriteLine("Вы ввели текст");

#if Команда
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            var line = $"Расстояние между точками составляет: {distance.ToString("0.00")}";

#elif Метод
            var distance = DistanceBetweenPoints(x1, y1, x2, y2);
            var line = $"Расстояние между точками составляет: {distance.ToString("0.00")}";

#else
            var line = "Не указана директива. Для дальнейшей работы укажите директиву.";

#endif
            Console.Write(line);
            Console.ReadKey();
        }

        static double DistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
