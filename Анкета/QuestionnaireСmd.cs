#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
В результате вся информация выводится в одну строчку.

*/
#endregion

//#define Конкатенация
//#define Форматирование
#define Интерполяция

using System;

namespace Questionnaire
{
    class QuestionnaireСmd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            var surname = Console.ReadLine();

            Console.WriteLine("Введите возраст:");
            var age = Console.ReadLine();

            Console.WriteLine("Введите рост:");
            var growth = Console.ReadLine();

            Console.WriteLine("Введите массу:");
            var weight = Console.ReadLine();

#if Конкатенация
            var space = " ";
            var line = name + space + surname + space + age + space + growth + space + weight;

#elif Форматирование
            var line = String.Format("{0} {1} {2} {3} {4}", name, surname, age, growth, weight);

#elif Интерполяция
            var line = $"{name} {surname} {age} {growth} {weight}";

#else
            var line = "Не указана директива. Для дальнейшей работы укажите директиву.";

#endif
            Console.Write(line);
            Console.ReadKey();
        }
    }


}

