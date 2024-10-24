Console.WriteLine(@$"
+---------------------------+
|   Bem vindo ao programa   |
|        banco XPTO         |
+---------------------------+
");


Console.WriteLine($"Poderia me informar quanto você recebe: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Poderia me informar quanto você gastou esse mês: ");
float gasto = float.Parse(Console.ReadLine()!);


if (salario >= gasto ){
Console.WriteLine("Gastos dentro do orçamento");

}else{
Console.WriteLine("Orçamento estourado");

}