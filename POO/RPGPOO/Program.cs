using System.Runtime.ConstrainedExecution;
using RPGPOO.Classes;

Console.WriteLine();
Console.WriteLine();

Personagens persona = new Personagens();

Console.WriteLine($" === Seja bem vindo ao RPG-Online ===");
Console.WriteLine();

Console.WriteLine($"=== Agora, personalize seu personagem! ===");
Console.WriteLine();

Console.WriteLine($"Digite o nome do seu personagem.");
persona.nome = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Qual é a idade do {persona.nome} ?");
persona.idade = int.Parse (Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine($"Qual é a armadura do {persona.nome} ?");
persona.armadura = Console.ReadLine();
Console.WriteLine();

Console.WriteLine($"Qual é a IA ajuda o {persona.nome} ?");
persona.IA = Console.ReadLine();
Console.WriteLine();

Console.WriteLine(@$"Nome do personagem:{persona.nome}
Idade do {persona.nome}: {persona.idade}
Armadura do {persona.nome}: {persona.armadura}
IA do {persona.nome}: {persona.IA}");

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Qual ação o {persona.nome} ira fazer.");
    Console.WriteLine($@"
    +----------------------------+
    |  1- atacar                 |
    |  2- defender               |
    |  3- restaurar armadura     |
    +----------------------------+");
Console.WriteLine();
Console.WriteLine();
    persona.escolha = int.Parse(Console.ReadLine()!);
    if (persona.escolha == 1)
    {
        Console.WriteLine($"O {persona.nome} {persona.atacar}");
        Console.WriteLine();
        
    }else if (persona.escolha == 2){
        Console.WriteLine($"O {persona.nome} {persona.defender}");
        Console.WriteLine();
        
    }else if (persona.escolha == 3){
        Console.WriteLine($"O {persona.nome} {persona.RestaurarArmadura}");
        Console.WriteLine();
        
    }else{
        Console.WriteLine($"=== O número digitado não foi aceito 😔 ===");
        Console.WriteLine();
    }
    
}