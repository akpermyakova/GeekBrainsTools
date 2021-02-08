#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;

*/
#endregion

//#define Plus
#define Multi
//#define Minus

using System;

namespace StructComplex
{
    class StructComplexCmd
    {
        static void Main(string[] args)
        {
            var Re1 = 1;
            var Im1 = 2;
            CComplex complex1 = new CComplex(Re1, Im1);

            var Re2 = 3;
            var Im2 = 4;
            CComplex complex2 = new CComplex(Re2, Im2);

#if Plus
            CComplex result = complex1.Plus(complex2);
#elif Multi
            CComplex result = complex1.Multi(complex2);
#elif Minus
            CComplex result = complex1.Minus(complex2);
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

        public CComplex(int Re, int _Im)
        {
            Im = _Im;
            this.Re = Re;
        }

        public CComplex Plus(CComplex x)
        {
            CComplex y = new CComplex();
            y.Im = Im + x.Im;
            y.Re = Re + x.Re;
            return y;
        } 
        
        public CComplex Multi(CComplex x)
        {
            CComplex y = new CComplex();
            y.Im = Re * x.Im + Im * x.Re;
            y.Re = Re * x.Re - Im * x.Im;
            return y;
        }

        public CComplex Minus(CComplex x)
        {
            CComplex y = new CComplex();
            y.Im = Im - x.Im;
            y.Re = Re - x.Re;
            return y;
        }

        public string AsString()
        {
            if (Im == 0) return ($"{Re}");
            if (Re == 0) return ($"{Im}i");
            if (Re == 0 && Im == 0) return ($"0");
            if (Im < 0) return ($"{Re}{Im}i");
            else return ($"{Re}+{Im}i");
        }
    }
}
