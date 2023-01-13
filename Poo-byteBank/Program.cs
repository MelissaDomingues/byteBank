using Poo_byteBank.Contas;

namespace Poo_byteBank
{
    public class Program
    {
        public static void Main()
        {
            ContaCorrente contaDoAndre = new ContaCorrente();
            contaDoAndre.titular.nome = "André Silva";
            contaDoAndre.n_Agencia = 15;
            contaDoAndre.conta = "1010-x";
            contaDoAndre.saldo = 100;

            Console.WriteLine("Titular da conta: " + contaDoAndre.titular);
            Console.WriteLine("Número da agência: " + contaDoAndre.n_Agencia);
            Console.WriteLine("Conta: " + contaDoAndre.conta);
            Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);

            contaDoAndre.Depositar(100);
            Console.WriteLine("Saldo da conta pós deposito: " + contaDoAndre.saldo);

            if (contaDoAndre.Saque(80) == true)
            {
                Console.WriteLine("Saldo da conta pós saque: " + contaDoAndre.saldo);
            }

            else
            {
                Console.WriteLine("Não é possível fazer esta operação... saldo indisponivel");
            }

            //Teste a = new Teste();

        }
    }

}


