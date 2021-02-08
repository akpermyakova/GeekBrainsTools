#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
Написать программу, демонстрирующую все разработанные элементы класса. 

** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.

*/
#endregion

//#define Plus
//#define Minus
//#define Multi
#define Division

using System;
using System.Collections.Generic;

namespace FractionsMath
{
    class FractionsMathCmd
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числитель первой дроби: ");
            int Num1 = GetInt();
            Console.Write("Введите знаменатель первой дроби: ");
            int Den1 = GetInt();
            Console.Write("Введите числитель второй дроби: ");
            int Num2 = GetInt();
            Console.Write("Введите знаменатель второй дроби: ");
            int Den2 = GetInt();

            FractionMath fraction1 = Enter(Num1, Den1);

            FractionMath fraction2 = Enter(Num2, Den2);

#if Plus
            FractionMath result = fraction1.Plus(fraction2);
#elif Minus
            FractionMath result = fraction1.Minus(fraction2);
#elif Multi
            FractionMath result = fraction1.Multi(fraction2);
#elif Division
            FractionMath result = fraction1.Division(fraction2);
#endif

            Console.WriteLine(result.AsString());
            Console.ReadKey();
        }

        static FractionMath Enter(int num, int den)
        {
            bool exception;
            FractionMath fraction = null;
            do
            {
                exception = false;
                try
                {
                    fraction = new FractionMath(num, den);
                }
                catch (ArgumentException e)
                {
                    exception = true;
                    Console.WriteLine("Ошибка: " + e.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    den = GetInt();
                }
            } while (exception);

            return fraction;
        }

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int result))
                    Console.Write("Неверный формат данных");
                else return result;
        }
    }

    class FractionMath
    {
        int Num;
        int Den;

        public FractionMath()
        {
            Num = 0;
            Den = 0;
        }

        public FractionMath(int _Num, int Den)
        {
            Num = _Num;
            this.Den = Den;
        }

        public FractionMath Plus(FractionMath x)
        {
            FractionMath y = new FractionMath();
            var numerator = Num * x.Den + x.Num * Den;
            var denominator = Den * x.Den;
            var nod = Nod(numerator, denominator);
            y.Num = numerator / nod;
            y.Den = denominator / nod;
            return y;
        }

        public FractionMath Minus(FractionMath x)
        {
            FractionMath y = new FractionMath();
            var numerator = Num * x.Den - x.Num * Den;
            var denominator = Den * x.Den;
            var nod = Nod(numerator, denominator);
            y.Num = numerator / nod;
            y.Den = denominator / nod;
            return y;
        }

        public FractionMath Multi(FractionMath x)
        {
            FractionMath y = new FractionMath();
            var numerator = Num * x.Num;
            var denominator = Den * x.Den;
            var nod = Nod(numerator, denominator);
            y.Num = numerator / nod;
            y.Den = denominator / nod;
            return y;
        }

        public FractionMath Division(FractionMath x)
        {
            FractionMath y = new FractionMath();
            var numerator = Num * x.Den;
            var denominator = Den * x.Num;
            var nod = Nod(numerator, denominator);
            y.Num = numerator/nod;
            y.Den = denominator/nod;
            return y;
        }

        public string AsString()
        {
            return $"{Num}/{Den}";
        }

        public int Nod(int num, int den)
        {
            while(num!=0 && den != 0)
            {
                if (num > den) num = num % den;
                else den = den % num;
            }
            return num + den;
        }
    }
}
