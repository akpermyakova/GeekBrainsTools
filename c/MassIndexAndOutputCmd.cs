#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
нужно ли человеку похудеть, набрать вес или все в норме;
*Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

*/
#endregion

using System;

namespace MassIndexAndOutput
{
    class MassIndexAndOutputCmd
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Введите массу:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост:");
            var growth = double.Parse(Console.ReadLine());

            var line = GetMassIndex(weight, growth);

            Console.WriteLine(line);
            Console.ReadKey();
        }

        static string GetMassIndex(double weight, double growth)
        {
            var minIndex = 18.50;
            var maxIndex = 24.99;

            var index = weight / (growth * growth);

            var line = String.Empty;
            if (index >= minIndex && index <= maxIndex) line = "Масса в норме";
            else line = (index < minIndex) ? $"Необходимо набрать {growth * growth * minIndex - weight} кг." : $"Необходимо похудеть на {weight-growth*growth*maxIndex} кг.";

            return line;
        }
    }
}