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
        public string ? Modelo { get; set; }
        // cor
        public string ? Cor { get; set; }
        // potencia
        public string ? Potencia { get; set; }
        // qtdPassageiro
        public int QtdPassageiros { get; set; }

        public void Ligar (){
            Console.WriteLine($"vrum-vrum!!!");
            
        }

        public void Desligar(){
            Console.WriteLine($"vrum");
            
        }

        public void Buzinar(){
            Console.WriteLine($"BI-BI");
            
        }
        // métodos
        // ligar, desligar, buzinar

    }
}