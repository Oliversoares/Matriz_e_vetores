// See https://aka.ms/new-console-template for more information
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}° numero:");
    numeros[i] = int.Parse(Console.ReadLine());
}
for (int j = 0; j < 5; j++)
{
    Console.WriteLine($"O valor na posição [{j}] = {numeros[j]}");

}
