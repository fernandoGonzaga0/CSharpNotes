/*
 
Em um banco temos clientes que possuem contas que são identificadas por um Número e Nome do cliente.

As operações que serão permitidas são: depositar, sacar e exibir saldo.

Serão 3 tipos de contas: corrente, poupança (com juros mensais que são aplicados ao saldo da conta), investimento (possuem taxa de remuneração que é 
aplicado ao saldo da conta e uma taxa de imposto que é descontado no saldo da conta).

Especificações: 

i) O saldo inicial das contas é zero;
ii) o juros da conta de poupança é 0,5% e os rendimentos devem ser calculados ao se efetuar um depósito e deve ser acrescido ao saldo da conta;
iii) a taxa da conta de investimento é 0,9% e deve ser aplicada a cada depósito e acrescida ao saldo;
iv) o imposto da conta de investimento é 0,1% e deve ser aplicado a cada saque na conta e debitado do saldo;
v) as contas de poupança e de investimento não permitem que o saldo da conta fique negativo;

*/

using _9_heranca_exemplo;

class Program
{
    public static void Main()
    {
        // Teste de Conta Corrente 
            // pessoa e ID da conta
            Console.WriteLine("----- CONTA CORRENTE -----");
            ContaCorrente contaCorrente1 = new();
            contaCorrente1.Numero = 001;
            contaCorrente1.Titular = "Fernando Gonzaga";
            Console.WriteLine($"Titular da conta: {contaCorrente1.Titular} ----- ID: {contaCorrente1.Numero}\nSaldo atual: {contaCorrente1.Saldo}");
            // deposito de R$ 1.000,00
            Console.WriteLine("Depositando R$ 1.000,00...");
            contaCorrente1.Depositar(1000);
            Console.WriteLine($"Saldo atual: {contaCorrente1.Saldo}");
            // saque de R$ 570,00
            Console.WriteLine("Sacando R$ 570,00...");
            contaCorrente1.Sacar(570);
            Console.WriteLine($"Saldo atual: {contaCorrente1.Saldo}");

        // Teste de Conta Poupança
            Console.WriteLine("\n\n----- CONTA POUPANÇA -----");
            ContaPoupanca contaPoupanca1 = new();
            contaPoupanca1.Numero = 0001;
            contaPoupanca1.Titular = "Fernando Gonzaga";
            Console.WriteLine($"Titular da conta: {contaPoupanca1.Titular} ----- ID: {contaPoupanca1.Numero}\nSaldo atual: {contaPoupanca1.Saldo}");
            // deposito de R$ 100,00
            Console.WriteLine("Depositando R$ 100,00...");
            contaPoupanca1.Depositar(100);
            Console.WriteLine($"Saldo atual: {contaPoupanca1.Saldo}");
            // saque de R$ 18,00
            Console.WriteLine("Sacando R$ 18,00...");
            contaPoupanca1.Sacar(18);
            Console.WriteLine($"Saldo atual: {contaPoupanca1.Saldo}");

        Console.ReadKey();
    }
}