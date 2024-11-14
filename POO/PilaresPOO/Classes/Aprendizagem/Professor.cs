
namespace PilaresPOO.Classes.Aprendizagem
{
    public class Professor : Pessoa
    {
        // Numero de Indentificação Fiscal - NIF
        public int NIF { get; set; }
        // salario
        public float Salario { get; set; }

        public Professor(int _nif)
        {
            NIF = _nif;

        }
    }

}