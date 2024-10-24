using System.Security.Principal;

Console.WriteLine(@$"
+------------------------------+
|    Bem vindo ao programa     |
|           Contador           |
|              de              |
|           Pessoas            |
+------------------------------+
");

int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsporte = 0;
int qtdNaoGostaEsporte = 0;


Console.WriteLine($"Qunatas pessoas tem na sua mesa ?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);



for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine();



    if(sexo == "f"){
        qtdMulher++;
        
    }else{
        qtdHomem++;
       
    }


    Console.WriteLine($"Você gosta de esporte ? s/n");
    string esporte = Console.ReadLine();

    if (esporte == "s")
    {
        qtdEsporte++;
    }else {
        qtdNaoGostaEsporte++;
    }
}
float percentual = (100 / qtdDeEntrevistados) * qtdEsporte;


Console.WriteLine($"Quantidade de Mulheres : {qtdMulher}");
Console.WriteLine($"Quantidade de Homens : {qtdHomem}");
Console.WriteLine($"Total de entrevistados : {qtdHomem + qtdMulher}");
Console.WriteLine($"Pessoas que gostam de esportes : {qtdEsporte}");
Console.WriteLine($"Pessoas que não gostam de esportes : {qtdNaoGostaEsporte}");
Console.WriteLine($"Percentual que gostam de esportes : {percentual}%");
