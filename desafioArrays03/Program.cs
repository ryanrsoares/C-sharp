// Faça um programa que receba a temperatura média de cada mês do ano e armazene essas temperaturas em um vetor. Calcule e imprima a maior e a menor temperatura do ano.

int [] temperatura =new int [12];

for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"Digite a temperatura média do mês {i + 1}:");
    temperatura[i] = int.Parse(Console.ReadLine()!);
}

int maiorTemperatura = temperatura.Max();
int menorTemperatura = temperatura.Min();

Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}ºC");
Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}ºC");