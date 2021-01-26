#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
где m — масса тела в килограммах, h — рост в метрах

*/
#endregion

using System;

namespace BodyMassIndex
{
    class BodyMassIndexCmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу:");
            if (double.TryParse(Console.ReadLine(), out var weight));
            else Console.WriteLine("Вы ввели текст");

            Console.WriteLine("Введите рост:");
            if (double.TryParse(Console.ReadLine(), out var growth));
            else Console.WriteLine("Вы ввели текст");

            var index = weight / (growth * growth);
            Console.Write($"Ваш индекс массы тела составляет: {index}");
            Console.ReadKey();
        }
    }
}
