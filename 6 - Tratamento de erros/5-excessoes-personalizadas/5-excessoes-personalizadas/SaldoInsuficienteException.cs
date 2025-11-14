using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_excessoes_personalizadas;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException()
    { }

    public SaldoInsuficienteException(string message)
    : base(message)
    { }

    public SaldoInsuficienteException(string message, Exception inner)
    : base(message, inner)
    { }

    public SaldoInsuficienteException(decimal saque, decimal saldo)
    : base($"\nException: valor do saque {saque} é superior ao saldo {saldo}")
    { }
}