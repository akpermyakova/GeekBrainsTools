#region Автор
// Пермякова А.К.
#endregion

#region Описание задачи
/*

1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
Продемонстрировать работу структуры;

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
            complex1.Im = 2;

            SComplex complex2;
            complex2.Re = 3;
            complex2.Im = 4;

#if Plus
            SComplex result = complex1.Plus(complex2);
#elif Multi
            SComplex result = complex1.Multi(complex2);
#elif Minus
            SComplex result = complex1.Minus(complex2);
#endif
            Console.WriteLine(result.AsString());
            Console.ReadKey();
        }
    }

    struct SComplex
    {
        public int Im;
        public int Re;
        
        public SComplex Plus(SComplex x)
        {
            SComplex y;
            y.Im = Im + x.Im;
            y.Re = Re + x.Re;
            return y;
        }

        public SComplex Multi(SComplex x)
        {
            SComplex y;
            y.Im = Re * x.Im + Im * x.Re;
            y.Re = Re * x.Re - Im * x.Im;
            return y;
        }

        public SComplex Minus(SComplex x)
        {
            SComplex y;
            y.Im = Im - x.Im;
            y.Re = Re - x.Re;
            return y;
        }

        public string AsString()
        {
            if(Im == 0) return ($"{Re}");
            if(Re == 0) return ($"{Im}i");
            if(Re == 0 && Im ==0) return ($"0");
            if (Im < 0) return ($"{Re}{Im}i");
            else return ($"{Re}+{Im}i");

        }
    }
}
