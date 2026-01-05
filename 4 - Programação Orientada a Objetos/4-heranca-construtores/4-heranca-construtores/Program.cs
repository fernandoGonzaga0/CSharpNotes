// Classes bases e derivadas podem ter seus próprios construtores.

class Program
{
    static void Main()
    {
        Aluno aluno1 = new(); // essa chamada pega apenas o construtor da classe Aluno SEM parâmetro e o construtor da classe Pessoa SEM parâmetro

        Aluno aluno2 = new("Fernando"); // construtor da classe Pessoa SEM parâmetro e da classe Aluno COM parâmetro
    }
}

// classe base
class Pessoa
{
    // construtor classe base sem parametro
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa sem parâmetro.");
    }

    // construtor classe base com parametro
    public Pessoa(string Nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parâmetro.");
    }

}

// classe derivada
class Aluno : Pessoa
{
    // construtor classe derivada sem parametro
    public Aluno() : base() // base() chama o construtor SEM PARAMETROS da classe base (Pessoa)
    {
        Console.WriteLine("Construtor da classe Aluno sem parâmetro.");
    }

    // construtor classe derivada com parametro
    public Aluno(string Nome)
    {
        Console.WriteLine("Construtor da classe Aluno com parâmetro.");
    }
}