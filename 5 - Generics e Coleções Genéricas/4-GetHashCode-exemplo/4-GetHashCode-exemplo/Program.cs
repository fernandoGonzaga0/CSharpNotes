/*

Os métodos Equals e GetHashCode podem ser sobrescritos conforme a necessidade. Por padrão, um código Hash é gerado para cada componente no projeto, independente de seu valor.

    Ex: pessoas com mesmo CPF possuem, por padrão, o mesmo Hash se não for configurado.

Objetivo: definir uma implementação personalizada para Equals e GetHashCode de forma a comparar se objetos da classe Pessoa são iguais com base na propriedade CPF. 
 
*/

public class Pessoa
{
    public int CPF;
    public string? Nome;

    public Pessoa (int cpf, string? nome)
    {
        CPF = cpf;
        Nome = nome;
    }

    // sobrescrita do método Equals e do GetHashCode, para evitar que eles retornem falso nas comparações entre objetos diferentes
    
    public override bool Equals(object? obj) // obj é o argumento passado para comparação. Ex: pessoa2 na comparação -> pessoa1.Equals(pessoa2));
    {
        if (obj == null) // se o objeto passado for null em Equals, retornar falso (apenas precaução)
        {
            return false;
        }

        if (obj is not Pessoa) // outra precaução, garantindo que o obj seja OBRIGATORIAMENTE da classe Pessoa
        {
            return false;
        }

        // other nesse caso é o objeto que queremos comparar com o primeiro. other aqui está convertendo o objeto obj no TIPO de dado utilizado
        var other = (Pessoa) obj; // essa conversão de obj para o tipo de dado (uma classe, no caso) é conhecida como downcasting

        return CPF.Equals(other.CPF);
    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}

public class Program
{
    public static void Main()
    {
        var pessoa1 = new Pessoa(0512245, "Fernando");
        var pessoa2 = new Pessoa(0512245, "Fernando");
        var pessoa3 = new Pessoa(2416878, "Fernando");

        Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
        Console.WriteLine("pessoa1 = " + pessoa1.GetHashCode());
        Console.WriteLine("pessoa2 = " + pessoa2.GetHashCode());
        Console.WriteLine("pessoa3 = " + pessoa3.GetHashCode());

        Console.WriteLine("\nComparando objetos Pessoa - Equals");
        Console.WriteLine("pessoa1.Equals(pessoa2)" + pessoa1.Equals(pessoa2));
        Console.WriteLine("pessoa2.Equals(pessoa3)" + pessoa2.Equals(pessoa3));
        Console.WriteLine("pessoa1.Equals(pessoa3)" + pessoa1.Equals(pessoa3));
    }
}