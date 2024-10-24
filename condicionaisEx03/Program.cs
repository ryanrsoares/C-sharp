Console.WriteLine(@$"
+---------------------------+
|   Bem vindo ao programa   |
|   tabela trigonometrica   |
+---------------------------+
");


Console.WriteLine($"Por favor me informe os valores do triângulo");
float lado1 = float.Parse(Console.ReadLine()!);
float lado2 = float.Parse(Console.ReadLine()!);
float lado3 = float.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2== lado3 && lado1 == lado3){
    Console.WriteLine($"O seu triângulo é Equilátero");
    
}else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3){
    Console.WriteLine($"O seu triângulo é Isóscele");

}else{
    Console.WriteLine($"O seu triângulo é Escaleno");

}
