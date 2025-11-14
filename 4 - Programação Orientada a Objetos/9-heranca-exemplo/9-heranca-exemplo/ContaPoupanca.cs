using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_heranca_exemplo;

public class ContaPoupanca : ContaCorrente // herdando as configurações de conta corrente, usada como base nesse cenário  
{

    // 1) ContaPoupanca possui juros de 5% aplicado
    public override double Juros { get; set; } = 0.005;

    // 2) A ContaPoupança, diferente da conta corrente, não pode ficar negativa. Farei a tratativa de impedir que isso aconteça.
    public override decimal Sacar(decimal valor)
    {  
        if (Saldo >= valor) // se o saldo for maior ou igual ao saque, OK
        {
            Saldo = Saldo - valor;
            return Saldo; // como o método tem parâmetro decimal, temos que retornar algum valor decimal
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
            return Saldo;// como o método tem parâmetro decimal, temos que retornar algum valor decimal
        }
    }

    // 3) Adicionado o juros de 5% em depósito na conta poupança
    public override decimal Depositar(decimal valor)
    {
        Saldo = Saldo + (Saldo * (decimal)Juros);
        return Saldo;
    }

}

