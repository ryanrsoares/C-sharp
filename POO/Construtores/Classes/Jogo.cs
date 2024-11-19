using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome { get; set; }
        public int lancamento { get; set; }
        public string genero { get; set; }
        public float preco { get; set; }

        public Jogo (string nm, int lcm, string gm, float pr){
            nome = nm;
            lancamento = lcm;
            genero = gm;
            preco = pr;
        }
        public void ExibirJojo(){
            Console.WriteLine(@$"
            Nome: {nome}
            Lançamento: {lancamento} Genêro: {genero}
            Preço Atual: R$ {preco}
            ");
            
        }

    }
}







/*
Altere o programa jogo para que contenha os seguintes elementos:
    -Menu de Opções
-       1) Cadastar Jogo
-       2) Listar Jogo
-       3) Sair

Os dados deverão ser solicitados ao usuário

O programa devera rodas até o usuário escolher a opção sair 
*/