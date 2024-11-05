using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Banco.Classes
{
    public class ContaCorrente
    {
        public int NumeroConta;
        public string? Titular;
        public float Saldo = 0f;

        public void Depositar (float valor){
            Saldo = Saldo + valor;
        }
        public void sacar (float valor){
            Saldo = Saldo - valor;
        }
    }
}