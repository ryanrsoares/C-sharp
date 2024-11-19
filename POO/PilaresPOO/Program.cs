
using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctRyan = new ContaCorrente();
ctRyan.Titular = "Ryan Rodrigues";
ctRyan.Depositar (1000f);


Console.WriteLine($"Titular da Conta: {ctRyan.Titular}");
Console.WriteLine($"Saldo Inicial da Conta: {ctRyan.getSaldo()}");

float valorSacado = ctRyan.Sacar(200f);

Console.WriteLine($"Valor do Saque: {valorSacado}");
Console.WriteLine($"Novo Saldo: {ctRyan.getSaldo()}");
