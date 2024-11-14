using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Veiculo
    {
           // props
        // marca,
        public string ? Marca { get; set; } 
        // modelo
        public string ? modelo { get; set; }
        // cor
        public string ? cor { get; set; }
        // potencia
        public string ? potencia { get; set; }
        // qtdPassageiro
        public int qtdPassageiros { get; set; }

        public void ligar (){
            Console.WriteLine($"vrum-vrum!!!");
            
        }

        public void desligar(){
            Console.WriteLine($"vrum");
            
        }

        public void buzinar(){
            Console.WriteLine($"BI-BI");
            
        }
        // métodos
        // ligar, desligar, buzinar

    }
}