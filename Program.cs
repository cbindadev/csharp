using System.Globalization;

namespace Teste;

public class Program
{
    public static void Main()
    {
        CalcularPar();
    }

    private static void CalcularPar()
    {
        Console.WriteLine("Digita um Numero");
        int numero = Convert.ToInt32(Console.ReadLine());

        int resultado = numero % 2;

        if (resultado == 0)
        {
            Console.Write("O numero é par: " + numero);
        }
        else
            Console.Write("O número é impar: " + numero);
    }
}
