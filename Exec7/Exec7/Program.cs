
Console.WriteLine("Digite seu nome: ");
var funcionario = Console.ReadLine();

Console.WriteLine("Digite o seu salário: ");
var salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quanto tempo de empresa: ");
var tempoEmpresa = Convert.ToInt32(Console.ReadLine());
double novoSalario = 0;
if (tempoEmpresa < 3)
{
    novoSalario = salario * 1.03;
}
else if (tempoEmpresa < 10){
    novoSalario = salario * 1.125;  
}
else
{
    novoSalario = salario * 1.20;
}
Console.WriteLine($"Olá {funcionario} o seu novo salário é R${novoSalario:F2}");

