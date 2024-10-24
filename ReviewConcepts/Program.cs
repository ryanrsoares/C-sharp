// Variaveis e tipos de dados
// estruturas cinducionais 
// laços de repetição
// arrays
Console.WriteLine(@"
+--------------------------------------------+
|           Programa de Cadastros            |
+--------------------------------------------+
|                    Olá :)                  |
|   Por favor digite os seus dados a baixo   |
+--------------------------------------------+
");

//nome
Console.WriteLine($"Olá, digite o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Oá {nome}, qual é seu sobrenome : ");
string sobrenome = Console.ReadLine();

//data de nascimento
Console.WriteLine($"Informe sua data de nascimento: ");
string DtNasc = Console.ReadLine();

//Email
Console.WriteLine($"Informe seu email: ");
string email = Console.ReadLine();

//telefone
Console.WriteLine($"Informe seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

//CPF
Console.WriteLine($"Informe seu CPF: ");
UInt128 cpf = UInt128.Parse(Console.ReadLine()!);


//endereço
Console.WriteLine($"Informe seu endereço: ");
string endereco = Console.ReadLine();

//idade
Console.WriteLine($"Que ano você nasceu ?");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

//estado civil
Console.WriteLine($"Informe seu estado civil: ");
string civil = Console.ReadLine();




Console.WriteLine(@$"
{nome} {sobrenome} você concluiu o seu cadastro ! 

Nome Completo: {nome} {sobrenome} 
Data de nascimento: {DtNasc}
Email: {email} 
Telefone: {telefone}
CPF: {cpf} 
Endereço: {endereco}
Idade: {idade}
Estado civil: {civil}");

// Console.WriteLine(sobrenome);

// nome
//data de nascimento
//email
//telefone
//cpf
//endereço
//idade - calcular baseado na data de nascimento
//estado civil
