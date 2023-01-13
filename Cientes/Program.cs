using Poo_byteBank;
using Poo_byteBank.Contas;
using Poo_byteBank.Titular;

Cliente cliente = new Cliente();
cliente.nome = "José Souza";
cliente.cpf = "454545454-54";
cliente.profissao = "Desenvolvedor";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-1";
conta.n_Agencia = 14;
conta.saldo = 452;

Console.WriteLine("Titular = "+ conta.titular.nome);
Console.WriteLine("CPF = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("N° Conta = " + conta.conta);
Console.WriteLine("N° Agência = " + conta.n_Agencia);
Console.WriteLine("Saldo = " + conta.saldo);
