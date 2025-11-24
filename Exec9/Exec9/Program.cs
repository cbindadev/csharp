
Console.Write("Digite o valor do saque: ");
int valor = Convert.ToInt32(Console.ReadLine());

int nota100 = valor / 100;
valor = valor - (nota100 * 100);

int nota50 = valor / 50;
valor =valor - (nota50 * 50);

int nota20 = valor / 20;
valor =valor - (nota20 * 20);

int nota10 = valor / 10;
valor =valor - (nota10 * 10);

int nota5 = valor / 5;
valor =valor - (nota5 * 5);

int nota2 = valor / 2;
valor = valor - (nota2 * 2);

int nota1 = valor;

Console.WriteLine("Distribuição das notas:");
Console.WriteLine($"R$100: {nota100}");
Console.WriteLine($"R$50: {nota50}");
Console.WriteLine($"R$20: {nota20}");
Console.WriteLine($"R$10: {nota10}");
Console.WriteLine($"R$5: {nota5}");
Console.WriteLine($"R$2: {nota2}");
Console.WriteLine($"R$1: {nota1}");
