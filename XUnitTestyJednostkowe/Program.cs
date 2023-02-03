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
                Console.WriteLine("Wpisz wartości dla A, B, C. Każdą zatwierdź Enterem. Pamiętaj, że 'A' musi być różne od zera!");

                a = double.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Wartość A nie może być zerem! Nie mogę obliczyć delty!");
                    Environment.Exit(0);
                }

                b = double.Parse(Console.ReadLine());
                c = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Podano niepoprawne dane!");
            }
        }

        public void liczenieRownanie()
        {
            delta = (b * b) - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Delta jest większa od 0. Dwa miejsca zerowe");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }

            if (delta == 0)
            {
                x1 = (-b / (2 * a));

                Console.WriteLine("Delta wynosi 0. Jedno miejsce zerowe");
                Console.WriteLine("x0 = " + x1);
            }

            if (delta < 0)
            {
                Console.WriteLine("Delta jest ujemna. Brak miejsc zerowych!");
            }

        }
    }
}
