using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public abstract class Pessoa
    {
        // Atributos - características
        // Visibilidade tipoDeDado nomeDaProp
        // nome
        public string ? Nome;
        // idade
        public int Idade;
        // cpf
        public string ? Cpf;
        // peso
        public float Peso {get; set;}
        // altura
        public float Altura {get; set;}

        // métodos - ações
        // visibilidade tipoDedadeRetornado nome (parametros) {corpo}
        // Envelhecer
        public void Envelhecer(){
            Idade++;
        }
        // engordar
        public void Engordar(float _kg){
            Peso = Peso + _kg;
        }
        // Emagrecer
        public void Emagrecer(float _kg){
            Peso = Peso - _kg;
        }
    }
}