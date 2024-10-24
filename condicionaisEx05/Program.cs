// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.


Console.WriteLine(@$"
+---------------------------+
|   Bem vindo ao programa   |
|     calculo das maças     |
+---------------------------+
");

Console.WriteLine("Digite o número de maçãs compradas:");
        float numeroDeMacas = float.Parse(Console.ReadLine());
        
        double precoPorMaca;

        if (numeroDeMacas >= 12){
            precoPorMaca = 0.30;
        } else {
            precoPorMaca = 0.25;
        }

        double valorTotal = numeroDeMacas * precoPorMaca;

        Console.WriteLine($"O valor total da compra é: R$ {valorTotal}");
