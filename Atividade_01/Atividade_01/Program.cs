// See https://aka.ms/new-console-template for more information
double[] nota = new double[3];
double soma = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Digite a {i + 1}° nota:");
    nota[i] = double.Parse(Console.ReadLine());
    soma = soma += nota[i];
}
double media = soma / nota.Length;
Console.WriteLine($"O valor da sua média de notas é: {media}");


