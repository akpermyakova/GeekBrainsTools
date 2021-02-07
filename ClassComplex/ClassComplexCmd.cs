#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

*/
#endregion

//#define Plus
//#define Multi
#define Minus

using System;

namespace StructComplex
{
    class StructComplexCmd
    {
        static void Main(string[] args)
        {
            SComplex complex1;
            complex1.Re = 1;
            complex1.Im = 1;

            SComplex complex2;
            complex2.Re = 2;
            complex2.Im = 2;

#if Plus
            Complex result = complex1.Plus(complex2);
#elif Multi
            Complex result = complex1.Multi(complex2);
#elif Minus
            SComplex result = complex1.Minus(complex2);
#endif
            Console.WriteLine(result.AsString());
            Console.ReadKey();
        }
    }

    public class CComplex
    {
        int Re;
        int Im;

        public CComplex()
        {
            Re = 0;
            Im = 0;
        }

        public CComplex(int _Im, int Re)
        {
            Im = _Im;
            this.Re = Re;
        }

        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.Im = x2.Im + Im;
            x3.Re = x2.Re + Re;
            return x3;
        }   
    }
}
