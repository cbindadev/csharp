using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culturaBR = new CultureInfo("pt-BR");
        CultureInfo culturaUS = new CultureInfo("en-US");

        const double taxaDolar = 5.15;

        Console.Write("Digite quanto dinheiro você tem na carteira (em R$): ");
        double reais = Convert.ToSingle(Console.ReadLine());

        double dolares = reais / taxaDolar;

        Console.WriteLine($"Você tem: {reais.ToString("C", culturaBR)}");
        Console.WriteLine($"Você pode comprar: {dolares.ToString("C", culturaUS)}");
    }
}