using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_byteBank
{
    public class contaCorrente
    {
        public int n_Agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public bool Saque (double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {           
                return false;
            }       
            
           

        }

            
            
    }
}
