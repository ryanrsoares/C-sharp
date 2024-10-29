//  Faça um programa que carregue dois vetores de 10 elementos numéricos cada um e imprima a intercalação desses dois

int [] arrayNumeros1 = {2, 5, 12, 21, 10, 27, 19, 11, 13, 9};
int [] arrayNumeros2 = {3, 6, 13, 22, 11, 28, 20, 12, 14, 10};

for (int i = 0; i < arrayNumeros1.Length; i++)
{
    if(i %2 == 0 ){
        Console.WriteLine($"{arrayNumeros1[i]}");
    }else {
        Console.WriteLine($"{arrayNumeros2[i]}");
    }

}