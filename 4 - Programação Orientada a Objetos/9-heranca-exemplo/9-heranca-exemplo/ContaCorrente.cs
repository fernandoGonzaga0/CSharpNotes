namespace _9_heranca_exemplo;

// conta corrente será a conta BASE, servindo para ser herdada em contas derivadas

public class ContaCorrente
{
    public int Numero { get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; } = 0.00m; // saldo inicial zerado
    public virtual double Juros { get; set; } = 0.00; // criando um virual Juros, pois o valor de juros será diferente em algumas contas

    // o método Sacar, pelo menos na conta corrente, pode ficar negativo (pode ser aplicado em cenários onde a conta fica negativa)
    public virtual decimal Sacar(decimal valor)
    {
        Saldo = Saldo - valor;
        return Saldo;
    }

    public virtual decimal Depositar(decimal valor)
    {
        Saldo += valor; // adicionando o valor no saldo
        Saldo = Saldo + (Saldo * (decimal)Juros); // aplicando o juros de depósito (aqui o valor será zerado -linha 16-, nas outras contas existe o valor apropriado)
        return Saldo;
    }

}
