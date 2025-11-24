Console.WriteLine("Digite a Altura: ");
var altura = Console.ReadLine();

Console.WriteLine("Digite a Largura: ");
var largura = Console.ReadLine();

var area = Convert.ToSingle(altura) * Convert.ToSingle(largura);
var tinta = area *0.5;

Console.WriteLine($"É necessário {tinta} litros de tinta para a area");

