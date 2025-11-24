Console.WriteLine("Digite o valor da casa: ");
var valorCasa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do seu salário: ");
var salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite em quantos anos deseja pagar: ");
var prazo = Convert.ToInt32(Console.ReadLine());

int prazoMeses = prazo * 12;

double parcela = valorCasa / prazoMeses;

if (parcela <= (salario*0.3))
{
    Console.WriteLine("empréstimo aprovado");
}
else
{
    Console.WriteLine("empréstimo reprovado");
}
