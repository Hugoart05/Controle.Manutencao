

class Program
{
    static void Main()
    {
        DateTime data1 = new DateTime(2023, 11, 10); // Data inicial
        int meses = 6;

        var proxima = data1.AddMonths(meses);
        var atual = DateTime.Today;
        var diaspara = proxima - atual;
        Console.WriteLine(diaspara.Days);
    }
}