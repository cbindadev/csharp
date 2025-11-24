// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um ano: ");
var ano = Convert.ToInt32(Console.ReadLine());

if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
{
    Console.WriteLine($"o ano {ano} é bissexto");
}
else
{
    Console.WriteLine("não é um ano bissexto");
}