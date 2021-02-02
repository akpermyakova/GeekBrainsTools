#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
программа пропускает его дальше или не пропускает.
С помощью цикла do while ограничить ввод пароля тремя попытками.

*/
#endregion

using System;

namespace CheckLoginAndPassword
{
    class CheckLoginAndPasswordCmd
    {
        static void Main(string[] args)
        {
            var attempt = 0;
            var maxAttempt = 3;
            string login, password = String.Empty;

            do
            {
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();

                if (UserIsAuthorized(login, password))
                {
                    Console.WriteLine("Вы успешно вошли.");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Неверные данные, попробуйте еще раз.");
                    attempt++;

                    if(attempt >= maxAttempt)
                    {
                        Console.WriteLine("Попытки закончились");
                        Console.ReadKey();
                        break;
                    }
                }
            }

            while (attempt < maxAttempt);
        }

        static bool UserIsAuthorized(string login, string password)
        {
            var validLogin = "root";
            var validPassword = "GeekBrains";
            if (login == validLogin && password == validPassword) return true;
            else return false;
        }
    }
}
