using System;
using Xunit;


namespace RownanieKwadratowe1.Testy
{
    public class RownanieKwadratoweTesty
    {
        [Theory]
        // [InlineData(A, B, C, wynik delty)]
        [InlineData(-1, 1, 1, 5)]
        [InlineData(-5, 0, -5, -100)]
        [InlineData(2, 1, -2, 17)]
        [InlineData(1, 2, 3, -8)]
        [InlineData(-3, 9, 3, 117)]
        [InlineData(2, 0, 0, 0)]
        [InlineData(0, 0, 0, 0)]
        

        public void liczenieRywnania_PorownanieObliczenDlaDeltyOrazWynikuDelty(double a, double b, double c, double wynik)
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
            Assert.Equal(wynikDelty, wynik);
        }
    }
}