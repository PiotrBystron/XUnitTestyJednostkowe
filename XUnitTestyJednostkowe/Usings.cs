global using Xunit;
using RownanieKwadratowe1;

static void Main(string[] args)
{
    Console.WriteLine("Program do liczenia funkcji kwadratowej");
    RownanieKwadratowe daneFunkcji = new RownanieKwadratowe();
    daneFunkcji.dodawanieWartosci();
    daneFunkcji.liczenieRownanie();
    Console.Write("Naci�nij ENTER aby wyj�� z programu.");
    while (Console.ReadKey().Key != ConsoleKey.Enter) { }
}