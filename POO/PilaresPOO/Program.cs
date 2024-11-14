// Herança
// Abstração
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes.Aprendizagem;
Console.Clear();


// Aluno spada = new Aluno();
// spada.Nome = "Herik Spada";

// Console.WriteLine($"========================================================================================");
// Console.WriteLine();
// Console.WriteLine($"{spada.Nome} Nasceu com {spada.Idade} anos");
// Console.WriteLine();
// Console.WriteLine($"========================================================================================");

// // dados do professor
// Professor sam = new Professor(123321);
// sam.Nome = "Samanta Melisa";
// sam.Idade = 22;

// // dados do aluno
// Aluno menegas = new Aluno();
// menegas.Cpf = "123.543.765-53";
// menegas.Idade = 50;
// menegas.Peso = 95.2f;
// menegas.Altura = 1.80f;
// menegas.Nome = "Erik Meneghetti";
// menegas.Matricula = 696969;
// menegas.Curso = "Dev";
// menegas.Media = 10.1f;

// Console.WriteLine($"========================================================================================");
// Console.WriteLine();

// Console.WriteLine($"Curso: {menegas.Curso}");
// Console.WriteLine();
// Console.WriteLine($"    Professor: {sam.Nome}");
// Console.WriteLine();
// Console.WriteLine($"    Identificação do(a) professor(a): {sam.NIF}");
// Console.WriteLine();
// Console.WriteLine();

// Console.WriteLine($"    Aluno: {menegas.Nome}");
// Console.WriteLine();
// Console.WriteLine($"    Idade do {menegas.Nome}: {menegas.Idade}");
// Console.WriteLine();
// Console.WriteLine($"    O peso do {menegas.Nome} é de {menegas.Peso}");
// Console.WriteLine();
// Console.WriteLine($"    A altura do {menegas.Nome} é de {menegas.Altura}");
// Console.WriteLine();
// Console.WriteLine($"    A matricula do {menegas.Nome} no curso é: {menegas.Matricula}");
// Console.WriteLine();
// Console.WriteLine($"    A media do {menegas.Nome} no curso é: {menegas.Media}");


// Console.WriteLine();
// Console.WriteLine($"========================================================================================");


//         // veiculos

//         // props
//         // marca, modelo, cor, potência, qtdPortas, qtdPassageiro

//         // métodos
//         // ligar, desligar, buzinar

// // Classes concretas que herdem de Veículo

// // carro - qtdPortas
// // avião - qtdPortas
// // moto - 

Moto motos = new Moto();
motos.modelo = "CB 400 four";
motos.Marca = "Honda";
motos.cor = "dourado com preto";
motos.potencia = "40cv";
motos.qtdRodas = 4;
motos.qtdPassageiros = 2;

Carro carros = new Carro();
carros.modelo = "Impada 66";
carros.Marca = "Chevrolet";
carros.cor = "vermelho";
carros.potencia = "270cv";
carros.qtdPorta = 4;
carros.qtdPassageiros = 5;

Aviao avioes = new Aviao();
avioes.modelo = "Boeing 747-8 Intercontinental";
avioes.Marca = "Boeing";
avioes.cor = "laranja e branco";
avioes.potencia = "66 500 hp (49 600 kW)";
avioes.qtdPorta = 4;
avioes.qtdPassageiros = 410 ;


Console.WriteLine($"=====================================================");
Console.WriteLine();
Console.WriteLine(@$"Carro {carros.Marca} {carros.modelo} 
Cor: {carros.cor}
Potência: {carros.potencia}
Quantidade de portas: {carros.qtdPorta}
Quantidade de passageiros: {carros.qtdPassageiros}.");


Console.WriteLine();
Console.WriteLine($"=====================================================");

Console.WriteLine($"=====================================================");
Console.WriteLine();
Console.WriteLine(@$"Avião {avioes.Marca} - {avioes.modelo}
Cor: {avioes.cor}
Potência: {avioes.potencia}
Quantidade de portas: {avioes.qtdPorta}
Quantidade de passageiros: {avioes.qtdPassageiros}");
Console.WriteLine();
Console.WriteLine($"=====================================================");

Console.WriteLine($"=====================================================");
Console.WriteLine();
Console.WriteLine(@$"Moto {motos.Marca} {motos.modelo}
Cor: {motos.cor}
Quantidade de portas: {motos.potencia}
Quantidades de passageiros: {motos.qtdPassageiros}");
Console.WriteLine();
Console.WriteLine($"=====================================================");