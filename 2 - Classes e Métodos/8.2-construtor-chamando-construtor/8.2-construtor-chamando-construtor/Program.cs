// CONSTRUTOR CHAMANDO CONSTRUTOR

public class Aluno
{
    // 4 componentes
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    // primeiro construtor
    public Aluno(string nome)
    {
        Nome = nome;
    }

    // segundo construtor
    public Aluno(string nome, int idade, string sexo, string aprovado) :this(nome) // usando this dessa forma, estamos referenciando o construtor que utiliza apenas nome como parâmetro
    {                                                                              // essa tratativa evita duplicação de código, pois agora podemos chamar apenas esse segundo construtor e ele conterá a variável nome
        // não precisamos usar Nome = nome; aqui, pois já referenciamos o construtor em this(nome).
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }
}

class Program
{
    public void Main()
    {
        Aluno aluno1 = new("Fernando", 25, "Masculino", "Sim"); // estamos utilizando o segundo construtor. Ele referencia o construtor 1 para obtermos o nome do aluno
    }
}

