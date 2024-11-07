using Construtores.Classes;
Console.Clear();

List<Jogo> estoqueJogos = new List<Jogo>();

Veiculo carro1 = new Veiculo("Ford", "ka", 2000, "vermelho");
Veiculo carro2 = new Veiculo("Ford", "Mustang", 1995, "amarelo");

Jogo jogo = new Jogo("Minecraft", 2009, "Jogo eletrônico de sobrevivência, Jogo eletrônico de ação e aventura e Jogabilidade não linear", 99);
Jogo jogo2 = new Jogo("Call Of Duty", 2003, "Ação", 23);
Jogo jogo3 = new Jogo("Roblox", 2006, "MMO, MMORPG, Simulação, Metaverso, Mundo virtual, Sandbox", 00);
Jogo jogo4 = new Jogo("Valorant", 2020, "Jogo de tiro tático", 00);

Aluno aluno1 = new Aluno("Cleiton", 15, "Escola Estadual Maria Trujilo Torloni");


estoqueJogos.Add(jogo);
estoqueJogos.Add(jogo2);
estoqueJogos.Add(jogo3);
estoqueJogos.Add(jogo4);

foreach (var Jogo in estoqueJogos){
    Jogo.ExibirJojo();
    Console.WriteLine();
    
    
}
// Console.WriteLine($"==========================================================");
// Console.WriteLine($"Carros");
// carro1.ExibirDados();
// carro2.ExibirDados();
// Console.WriteLine($"==========================================================");
// Console.WriteLine($"Jogo");
// jogo.ExibirJojo();
// Console.WriteLine($"==========================================================");
// Console.WriteLine($"Aluno");
// aluno1.ExibirAluno();
// Console.WriteLine($"==========================================================");   