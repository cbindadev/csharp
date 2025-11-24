
Console.WriteLine("Digite os números separados por espaço:");
string[] entrada = Console.ReadLine().Split(' ');
int[] numeros = new int[entrada.Length];

for (int i = 0; i < entrada.Length; i++)
{
    numeros[i] = Convert.ToInt32(entrada[i]);
}

// Pede o valor alvo
Console.WriteLine("Digite o valor alvo:");
int alvo = Convert.ToInt32(Console.ReadLine());

// Procura os dois números
for (int i = 0; i < numeros.Length; i++)
{
    for (int j = i + 1; j < numeros.Length; j++)
    {
        if (numeros[i] + numeros[j] == alvo)
        {
            Console.WriteLine($"Índices encontrados: {i} e {j}");
            return; 
        }
    }
}

Console.WriteLine("Nenhuma combinação encontrada.");