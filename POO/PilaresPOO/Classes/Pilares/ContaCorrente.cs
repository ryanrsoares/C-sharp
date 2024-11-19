
namespace PilaresPOO.Classes.Pilares
{
    public class ContaCorrente : Conta
    {
        public float Limite { get; set; }
        public bool Tranferir (float valor, Conta contaDestino){
            return false;//simulando que deu erro.
        }
    
        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
            return true;
            }
            else
            {
                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                return valor;
            } else{
                Console.WriteLine($"Valor Menor que o Saldo");
                

                return 0;
            }

        }
    }
}