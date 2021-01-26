#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

*/
#endregion

#define Метод
//#define Команда

using System;

namespace Passport
{
	class PassportCmd
	{
		static void Main(string[] args)
		{
			Console.Write("Введите имя и фамилию: ");
			var name = Console.ReadLine();

			Console.Write("Введите город: ");
			var city = Console.ReadLine();

#if Команда		
			var line = $"{name}, {city}";

#elif Метод
			var line = Print(name, city);

#else
            var line = "Не указана директива. Для дальнейшей работы укажите директиву.";

#endif
			var halfCount = line.Length / 2;
			Console.SetWindowSize(100, 50);
			Console.SetBufferSize(100, 50);
			Console.SetCursorPosition(50 - halfCount, 25);
			Console.WriteLine(line);
			Console.ReadKey();
		}

		static string Print(string name, string city)
		{
			var value = ($"{name}, {city}");
			return value;
		}
	}
}
