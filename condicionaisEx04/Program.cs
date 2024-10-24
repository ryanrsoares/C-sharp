//  Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

//    - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
//    - ACESSO    NEGADO    caso    a    senha    seja    inválida
int senhaCorreta = 1234; 
Console.WriteLine(@$"
+---------------------------+
|   Bem vindo ao programa   |
|     comfirm password      |
+---------------------------+
");



Console.WriteLine($"Digite uma senha:");
int senha = int.Parse(Console.ReadLine()!);

if(senha == senhaCorreta){
Console.WriteLine($"ACESSO PERMITIDO");

}else {
    Console.WriteLine($"ACESSO NEGADO, DIGITE A SENHA CORRETA CABAÇO");
    
}
