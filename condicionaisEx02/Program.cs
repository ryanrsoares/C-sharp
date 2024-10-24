Console.WriteLine(@$"
+----------------------------------+
|       Bem vindo ao programa      |
|             fotTable             |
+----------------------------------+
");





Console.WriteLine($"quantos gols o time A fez ?");
int golsa = int.Parse(Console.ReadLine()!);
Console.WriteLine($"quantos gols o time B fez ?");
int golsb = int.Parse(Console.ReadLine()!);


if(golsa > golsb){
Console.WriteLine($"O time A fez mais gols.");

}else if(golsa < golsb){
Console.WriteLine($"O time B fez mais gols");

}else {
Console.WriteLine($"Empate");

}