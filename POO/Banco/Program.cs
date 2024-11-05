using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubanquinho");
Console.WriteLine();

//correntistas
ContaCorrente contaEmilly = new ContaCorrente();
ContaCorrente contaClara = new ContaCorrente();

contaEmilly.Titular = "Emilly";
contaEmilly.Depositar (1000000f);

contaClara.Titular = "Clara";
contaClara.Depositar (1000000f);


Console.WriteLine($"Conta da {contaEmilly} tem R${contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara} tem R${contaClara.Saldo}");

contaClara.sacar(250f);

Console.WriteLine($"Você sacou e sua conta ficou com R${contaClara.Saldo}");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Conta de {contaEmilly.Titular} ten R$ {contaEmilly.Saldo}");
Console.WriteLine($"Conta de {contaClara.Titular} ten R$ {contaClara.Saldo}");
Console.WriteLine();