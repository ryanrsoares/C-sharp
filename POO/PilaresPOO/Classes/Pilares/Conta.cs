
namespace PilaresPOO.Classes.Pilares
{
    public abstract class Conta
    {
        protected float Saldo { get; set; }
        public string ? Titular { get; set; }

        public abstract float Sacar (float valor);
        public abstract bool Depositar (float valor);
        
        //devolde o saldo da conta
        public float getSaldo(){
            return Saldo;
        }
    }
}