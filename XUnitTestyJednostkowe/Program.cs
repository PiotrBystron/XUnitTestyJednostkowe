using System;


namespace RownanieKwadratowe1
{
    public class RownanieKwadratowe
    {
        public double a, b, c, x1, x2, delta;


        public void dodawanieWartosci()
        {
            try
            {
                Console.WriteLine("Podaj wartość a,b,c. Każdą zatwierdź Enterem");

                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Podano nieprawidłowe dane.");
            }
        }

        public void liczenieRownanie()
        {
            delta = (b * b) - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }

            if (delta == 0)
            {
                x1 = (-b / (2 * a));
            }

            if (delta < 0)
            {
                Console.WriteLine("Delta jest ujemna - brak miejsc zerowych!");
            }

        }
    }
}
