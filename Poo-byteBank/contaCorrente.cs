using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_byteBank
{
    public class ContaCorrente
    {
        public int n_Agencia { get; set; }
        public string conta { get; set; }
        public string titular { get; set; }
        public double saldo { get; set; }

        public ContaCorrente()
        {
            n_Agencia = 0;
            saldo = 0;
            titular = "";
            conta = "";
        }

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

        public bool Transferir (double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }
        

            
    }
}
