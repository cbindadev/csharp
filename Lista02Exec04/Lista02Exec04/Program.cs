

Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine();


char[] s = palavra.ToCharArray();

for (int i = 0; i < s.Length / 2; i++)
{
    char temp = s[i];
    s[i] = s[s.Length - 1 - i];
    s[s.Length - 1 - i] = temp;
}

Console.WriteLine("Invertida: " + new string(s));
