// Se um membro de uma classe derivada tiver o mesmo nome do membro de uma classe base,C# retornará um erro.

// É possível herdar membros da classe base com o mesmo nome, mas é necessário usar o método 'new' e setar as novas ações para a classe derivada.
// Essa ação SOBRESCREVE o membro da classe base na classe derivada (a classe base seguirá normalmente).

class Pessoa
{
    public string? Nome { get; set; }
    public string? Saudacao() => $"Oi, eu sou o {Nome}"; // método Saudacao() da classe base
}

class Aluno : Pessoa
{
    public string? Curso { get; set; }
    public new string? Saudacao() => $"Oi, eu sou o {Nome} do curso de: {Curso}";  // método Saudacao() da classe derivada (obs -> aqui usamos New() para diferenciar)
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Fernando";
        aluno.Curso = "Ciências da computação";
        Console.WriteLine(aluno.Saudacao());
    }
}