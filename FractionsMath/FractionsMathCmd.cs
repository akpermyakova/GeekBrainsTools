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

#define Plus
//#define Minus
//#define Multi
//#define Division

using System;
using System.Collections.Generic;

namespace FractionsMath
{
    class FractionsMathCmd
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первая дробь ");
            var fraction1 = CreateFraction();
            Console.WriteLine("Вторая дробь ");
            var fraction2 = CreateFraction();
#if Plus
            Console.WriteLine("Операция сложения");
            FractionMath result = fraction1.Plus(fraction2);
#elif Minus
            Console.WriteLine("Операция вычитания");
            FractionMath result = fraction1.Minus(fraction2);
#elif Multi
            Console.WriteLine("Операция умножения");
            FractionMath result = fraction1.Multi(fraction2);
#elif Division
            Console.WriteLine("Операция деления");
            FractionMath result = fraction1.Division(fraction2);
#endif
            Console.WriteLine();
            Console.WriteLine($"Результат равен {result}");
            Console.ReadKey();
        }

        static FractionMath CreateFraction()
        {
            Console.Write("Введите числитель дроби: ");
            int num = GetInt();
            
            int den = 0;

            while (den == 0)
            {
                Console.Write("Введите знаменатель дроби, который не должен быть равен 0: ");
                den = GetInt();
                try
                {
                    if (den == 0) throw new ArgumentException("число не должно быть равно нулю");
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var fraction = new FractionMath(num, den);
            
            Console.WriteLine($" ----- Создана дробь {fraction} -----");
            Console.WriteLine();
            return fraction;
        }

        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int result))
                    Console.Write("Неверный формат данных. Введите значение еще раз: ");
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
            Den = 1;
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

        public override string ToString()
        {
            return $"{Num}/{Den}";
        }

        public static int Nod(int num, int den)
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
