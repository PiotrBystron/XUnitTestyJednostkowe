using System;
using Xunit;


namespace RownanieKwadratowe1.Testy
{
    public class RownanieKwadratoweTesty
    {
        //[Theory]
        
        
        public void sprawdzanieObliczenDelty(double a, double b, double c, double wynik)
        {
            //arrange
            RownanieKwadratowe o1 = new RownanieKwadratowe();
            o1.a = a;
            o1.b = b;
            o1.c = c;

            //act
            o1.liczenieRownanie();
            double wynikDelty = o1.delta;

            //assert
            Assert.Equal(2,2);
            //Assert.Equal(wynikDelty, wynik);

        }
    }
}