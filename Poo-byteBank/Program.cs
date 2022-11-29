using Poo_byteBank;

contaCorrente contaDoAndre = new contaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.n_Agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;

Console.WriteLine("Titular da conta: " + contaDoAndre.titular);
Console.WriteLine("Número da agência: " + contaDoAndre.n_Agencia);
Console.WriteLine("Conta: " + contaDoAndre.conta);
Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);