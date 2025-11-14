using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_heranca_exemplo;

public class ContaInvestimento : ContaCorrente // herdando as configurações de conta corrente, usada como base nesse cenário 
{
    // 1) ContaInvestimento possui juros de 9% no depósito
    public override double Juros { get; set; } = 0.009;

    // 2) ContaInvestimento possui imposto a ser retirado a cada saque
    public double Imposto { get; set; } = 0.001;

    // 3) Método Sacar() será diferente aqui, aplicando o imposto na retirada do valor (imposto -> saldo * imposto)
    public override decimal Sacar(decimal valor)
    {
        if (Saldo >= valor)
        {
            Saldo = Saldo - valor - (Saldo * (decimal)Imposto);
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente...");
            return Saldo;
        }
    }

    // 4) Método Depositar() será diferente aqui, adicionando o juros de 9% no depósito
    public override decimal Depositar(decimal valor)
    {
        Saldo = Saldo + (Saldo * (decimal)Juros);
        return Saldo;
    }
}
