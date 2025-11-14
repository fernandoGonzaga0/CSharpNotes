/*
 
É possível criar exceções personalizadas no C#.

Para isso, realize: finalizar o nome da exceção criada com a palavra Exception | implementar os três construtores comuns 

Sintaxe: 

public class MinhaExcecaoExeption : Exception 
{
    public MinhaExcecaoException()             
    {}

    public MinhaExcecaoException(string message)
    :base(message)
    {}

    public MinhaExcecaoException(string message, Exception inner)
    :base(message, inner)
    {}
}

*/
using _5_excessoes_personalizadas;

try
{
    Conta conta1 = new Conta(001, "Fernando", 100m);
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(68);
    Console.WriteLine($"Depositando...\nSaldo: {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Sacando...\nSaldo: {conta1.Saldo}");
}

catch (SaldoInsuficienteException ex) 
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();
 

public class Conta
{
    public Conta(int numero, string? titular, decimal saldo)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldo;
    }
    public int Numero {  get; set; }
    public string? Titular { get; set; }
    public decimal Saldo { get; set; }
    public decimal Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depositou: {valor}");
        return Saldo;
    }
    public decimal Sacar(decimal valor)
    {
        Console.WriteLine($"Sacou: {valor}");
        if (Saldo < valor)
        {
            // throw new ArgumentException("Saldo insuficiente!");   -> para não usar um argumento genérico dessa forma, criarei uma classe especifica para essa validação de saldo
            throw new SaldoInsuficienteException(valor, Saldo); // a mensagem de exceção exibida será validada aqui, com a classe que criamos fora de Program.cs
        }
        else
        {
            Saldo -= valor;
        }
        return Saldo;
    }
    public override string ToString() // sobrescrevendo o método ToString(). Quando ele for chamado, adotará agora esse novo formato, ao invés de apenas converter o dado em string
    {
        return $"Conta: {Numero} - {Titular} | Saldo = {Saldo}";
    }
}