using Poo_byteBank.Titular;
using Poo_byteBank.Contas;

namespace UsuárioConta
{

    public class Program
    {
        public static void Main()
        {
            ContaCorrente a = new ContaCorrente();
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

                ContaCorrente contaDaMaria = new ContaCorrente();
                contaDaMaria.titular.nome = "Maria Rios";
                contaDaMaria.n_Agencia = 17;
                contaDaMaria.conta = "1010-5";
                contaDaMaria.saldo = 350;

                Console.WriteLine(""); 
                Console.WriteLine("Titular da conta: " + contaDaMaria.titular);
                Console.WriteLine("Número da agência: " + contaDaMaria.n_Agencia);
                Console.WriteLine("Conta: " + contaDaMaria.conta);
                Console.WriteLine("Saldo da conta: " + contaDaMaria.saldo);

                contaDoAndre.Transferir(50, contaDaMaria);
                Console.WriteLine("");
                Console.WriteLine("Saldo do André depois da transferência = " + contaDoAndre.saldo);
                Console.WriteLine("Saldo da Maria depois da Transferência = " + contaDaMaria.saldo);



            }

        }
    }
}
