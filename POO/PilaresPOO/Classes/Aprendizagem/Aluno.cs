using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PilaresPOO.Classes.Aprendizagem
{
    public class Aluno : Pessoa
    {
        // matricula
        public int Matricula { get; set; }
        // curso
        public string ? Curso { get; set; }
        // media
        public float Media { get; set; }
    }
}