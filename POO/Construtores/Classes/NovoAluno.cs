namespace Construtores.Classes
{
    public class Aluno2
    {
        public string ? Nome;
        public int CPF;


        public Aluno2 (){}
        public Aluno2(string _chuchu){
            Nome = _chuchu;
        }

        public Aluno2 (string _nome, int _CPF){
            Nome = _nome;
            CPF = _CPF;
        }
    }
}