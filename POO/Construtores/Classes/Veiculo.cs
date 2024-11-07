using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Construtores.Classes
{
    public class Veiculo
    {
        // visibilidade tempoDeDado nome;
        public string marca { get; set; }
        public string modelo { get; set; }

        public int ano { get; set; }
        public string cor { get; set; }

        // Métodos construtores (métodos especiais que não retornam valores)

        public Veiculo(string ma, string md, int an, string cr){
            marca = ma;
            modelo = md;
            cor = cr;
            ano = an;
        }

        public void ExibirDados(){
            Console.WriteLine(@$"
            Marca: {marca}
            Modelo: {modelo}
            Ano: {ano}
            Cor: {cor}
            ");
            
        }
    }
}