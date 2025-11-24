// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Digite a distância em KM que deseja percorrer: ");
var distancia = Convert.ToSingle(Console.ReadLine());
if (distancia <= 200)
{
    var preco = (distancia * 0.5) + 5.65;
    Console.WriteLine($"O preço da viagem será {preco.ToString("C")}");
}
else
{
    var preco = (distancia * 0.45) + 5.65;
    Console.WriteLine($"O preço da viagem será {preco.ToString("C")}");
}

