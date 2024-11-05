using Calculador.Classes;

Calculadora numeros = new Calculadora();

Console.WriteLine($"Digite uma opreração (+, -, *, / ou soma, subtração, multiplicação e divisão)");
string operacao = Console.ReadLine();


Console.WriteLine($"Agora digite um numero para a opreração:");
float n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Agora digite outro numero para a opreração:");
float n2 = int.Parse(Console.ReadLine()!);
    // numeros.numero1 = n1;
    // numeros.numero2 = n2;

if (operacao == "+")
{
    numeros.somar();
}
else
{
    
}