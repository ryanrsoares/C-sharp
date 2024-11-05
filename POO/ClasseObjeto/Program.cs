using ClasseObjeto.Classes;
using System.Net.Http.Headers;
using ClasseObjeto.Classes;
using System.ComponentModel;

Console.Clear();
Console.WriteLine($"** Bem vundo ao programa Zoosharp **");
Console.WriteLine();

// importando as classes de dentro da pasta Classes

//cria o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Golden";
cachorro.cor = "Caramelo";
cachorro.idade = 5;

// Console.WriteLine($"Nome do cahorrinho: {cachorro.nome}");
// Console.WriteLine($"Raça do {cachorro.nome} é: {cachorro.raca}");
// Console.WriteLine($"Cor do {cachorro.nome} é: {cachorro.cor}");
// Console.WriteLine($"Idade do {cachorro.nome} é: {cachorro.idade}");

Animal peixe = new Animal();

peixe.nome = "betinho";
peixe.raca = "Glaucus atlanticus";
peixe.cor = "Azul, branco e preto";
peixe.idade = 3;

// Console.WriteLine($"Nome do peixe: {peixe.nome}");
// Console.WriteLine($"A raça do {peixe.nome}: {peixe.raca}");
// Console.WriteLine($"A cor do {peixe.nome}: {peixe.cor}");
// Console.WriteLine($"A idade do {peixe.nome}: {peixe.idade}");

Animal aranha = new Animal();


aranha.nome = "luca";
aranha.raca = "Theraphosa blondi";
aranha.cor = "marrom";
aranha.idade = 15;

// Console.WriteLine(@$"animal 1
//     {cachorro.nome}
//     {cachorro.raca}
//     {cachorro.cor}
//     {cachorro.idade}
// ");

// Console.WriteLine(@$"animal 2
//     {peixe.nome}
//     {peixe.raca}
//     {peixe.cor}
//     {peixe.idade}
// ");

// Console.WriteLine(@$"animal 3
//     {aranha.nome}
//     {aranha.raca}
//     {aranha.cor}
//     {aranha.idade}
// ");


cachorro.FazerBarulho("AU AU");
Console.WriteLine($"Idade do {cachorro.nome} é {cachorro.idade}");
cachorro.Envelhecer();
Console.WriteLine($"Nova idade do {cachorro.nome} é {cachorro.idade}");

peixe.FazerBarulho("Blup! Blup!");
Console.WriteLine($"Idade do {peixe.nome} é {peixe.idade}");
peixe.Envelhecer();
Console.WriteLine($"Nova idade do {peixe.nome} é {peixe.idade}");

aranha.FazerBarulho("Estridularão, Estridularão");
Console.WriteLine($"Idade do {aranha.nome} é {aranha.idade}");
aranha.Envelhecer();
Console.WriteLine($"Nova idade do {aranha.nome} é {aranha.idade}");