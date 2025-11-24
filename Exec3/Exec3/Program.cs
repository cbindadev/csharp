Console.WriteLine("Digite a velocidade do carro: ");
var velocidade = Convert.ToInt32(Console.ReadLine());

if (velocidade > 80)
{
    var multa = Convert.ToSingle((velocidade - 80)*5);
    Console.WriteLine($"a multa por excesso de velocidade é de: R${multa}");
}
else
{
    Console.WriteLine("Velocidade permitida");
}
