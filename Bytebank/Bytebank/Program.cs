using Bytebank.Contas;
using Bytebank.Titular;
/*
ContaCorrente contaDoLucca = new ContaCorrente();
contaDoLucca.titular = "Lucca Gomes";
contaDoLucca.numero_agencia = 123;
contaDoLucca.conta = "1010=X";
contaDoLucca.saldo = 2000;

ContaCorrente contaDaBruna = new ContaCorrente();
contaDaBruna.titular = "Bruna Campos";
contaDaBruna.numero_agencia = 456;
contaDaBruna.conta = "1010=Y";
contaDaBruna.saldo = 1000;

Console.WriteLine("Saldo da conta do Lucca " + contaDoLucca.saldo);
Console.WriteLine("Saldo da conta da Bruna " + contaDaBruna.saldo);

contaDoLucca.Transferir(200, contaDaBruna);

Console.WriteLine("Saldo da conta do Lucca " + contaDoLucca.saldo);
Console.WriteLine("Saldo da conta da Bruna " + contaDaBruna.saldo);

*/

/*
Cliente cliente = new Cliente();

cliente.nome = "Lucca Gomes";
cliente.cpf = "123456789";
cliente.profissao = "Dev";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.numero_agencia = 123;
conta.conta = "1010=X";
conta.saldo = 2000;

Console.WriteLine("Titular = " + conta.titular.nome);
Console.WriteLine("CPF = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("Nº da Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("Nº da Agência = " + conta.numero_agencia);

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new cliente();
conta2.numero_agencia = 123;
conta2.conta = "1010=X";
conta2.saldo = 2000;
*/

ContaCorrente conta3 = new ContaCorrente();
conta3.Numero_Agencia = 18;
conta3.Conta = "1010-Z";
conta3.SetSaldo(1000);

Console.WriteLine(conta3.GetSaldo());
Console.WriteLine(conta3.Numero_Agencia);
Console.WriteLine(conta3.Conta);
