using Construtores.Classes;

Console.Clear();

// ========== veiculo code ==============

// Veiculo carro1 = new Veiculo("BMW", "i8", 2004, "Preto");
// Veiculo carro2 = new Veiculo("Aston Alpha Martin", "Valour", 2012, "Branco");

// carro1.ExibirDados();
// carro2.ExibirDados();


// // quebra de ativ

// =============== aluno code ==================



// Console.WriteLine($"==============================");

// Aluno alun = new Aluno("Herik", 17, "sim");
// alun.ExibirDadosAluno();

// // quebra de ativ




// Console.WriteLine($"==============================");

// List<Jogo> estoqueJogos = new List<Jogo>();

// Jogo minecraft = new Jogo("Minecraft", " Jogo eletrônico de sobrevivência, Jogo eletrônico de ação e aventura, Jogabilidade não linear", 2009, 99.00f);

// Jogo daysGone = new Jogo("Days Gone", "Jogo eletrônico de ação e aventura, Jogo eletrônico de tiro, Survival horror, Jogabilidade não linear, Adventure", 2009, 119.99f );

// Jogo dbd = new Jogo ("Dead By Daylight", "Survival horror, Jogo eletrônico de luta", 2016, 19.99f);

// Jogo spiderMan2 = new Jogo("Marvels Spider-Man 2", " Jogo eletrônico de ação e aventura, Jogo eletrônico de luta, Jogo eletrônico de plataforma, Adventure", 2023, 349.90f);

// estoqueJogos.Add(minecraft);
// estoqueJogos.Add(daysGone);
// estoqueJogos.Add(dbd);
// estoqueJogos.Add(spiderMan2);


// int Escolha = 0;
// string espera = "";

// do
// {
//     Console.Clear();
//     Console.WriteLine(@$"
//     *** Programa Cadastro de Jogo *** 
//     === Menu de Opções ===
//         1) Cadastrar Jogo
//         2) Listar Jogos
//         3) Sair
//     ");
//     Escolha = int.Parse(Console.ReadLine()!);

//     if (Escolha == 1)
//     {
//         Console.WriteLine(@$"Ok... Vamos começar!");
//         Console.WriteLine();

//         Console.Write($"Digite o nome do jogo: ");
//         string name = Console.ReadLine()!;

//         Console.Write($"Digite o genero do jogo: ");
//         string gen = Console.ReadLine()!;

//         Console.Write($"Digite o lançamento do seu jogo: ");
//         int lanc = int.Parse(Console.ReadLine()!);

//         Console.WriteLine($"Digite o preço do seu jogo: ");
//         int price = int.Parse(Console.ReadLine()!);

//         Jogo newGame = new Jogo (name, gen, lanc, price);

//         estoqueJogos.Add(newGame);

//         Console.WriteLine($"Pressione uma Enter pra continuar");
//         espera = Console.ReadLine()!;//espera o enter
//     }

//     else if (Escolha == 2)
//     {
//         foreach(var jogo in estoqueJogos)
//     {
//         jogo.ExibirDadosGame();
//     }
//         espera = Console.ReadLine()!;
//     }

//     else if (Escolha == 3)
//     {
//         Console.Clear();
//         Console.WriteLine($"Você escolheu sair do programa! Até logo");
//         Console.WriteLine($"Pressione uma Enter pra continuar");
//         espera = Console.ReadLine()!;//espera o enter
//     }
//     else
//     {
//         Console.WriteLine($"Opção Inválida");
//         espera = Console.ReadLine()!;

//     }
// } while (Escolha != 3);

Aluno2 herikSpada = new Aluno2 ("Herik De lima Spada");
herikSpada.CPF = 0707;

Aluno2 ryanKure = new Aluno2 ("Ryan Kure");
ryanKure.CPF = 6969;

Aluno2 eduProf = new Aluno2 ();

Console.Write(ryanKure.Nome);

Console.WriteLine();

Console.WriteLine();

Console.Write($"CPF DE RYAN KURE: {ryanKure.CPF}");

Console.WriteLine();

Console.WriteLine();

Console.WriteLine();

// ==================================================

Console.Write(herikSpada.Nome);

Console.WriteLine();

Console.WriteLine();

Console.WriteLine($"CPF DE HERIK SPADA: {herikSpada.CPF}");

Console.WriteLine();

Console.WriteLine();

Console.WriteLine();

// =====================================================

Console.Write($"Qual seu nome: ");
eduProf.Nome = Console.ReadLine();

Console.WriteLine();

Console.WriteLine();

Console.Write(eduProf.Nome);

Console.WriteLine();

Console.WriteLine();

Console.WriteLine($"CPF DE {eduProf.Nome} : {eduProf.CPF}");

Console.WriteLine();

Console.WriteLine();

Console.WriteLine();

// =====================================================