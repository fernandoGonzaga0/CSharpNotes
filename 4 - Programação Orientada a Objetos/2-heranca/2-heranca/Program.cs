/*

Em C#, a relação da classe derivada e a classe base é estabelecica através do sinal de dois pontos :

Ex: sistema de cadastro de professores, alunos e coordenadores em uma escola. Todos são PESSOAS.
*/

class Program
{
    static void Main()
    {

        // criando aluno com campos da classe Aluno e da classe pai Pessoa
        Aluno aluno1 = new();
        aluno1.Nome = "Fernando";
        aluno1.Email = "fernandooliv2107@gmail.com";
        aluno1.Sexo = "Masculino";
        aluno1.NotaFinal = 8;
        aluno1.Aprovado = true;
        aluno1.Curso = "Ciências da Computação";
        aluno1.Identificar();
    }
}

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Sexo { get; set; } 
    public void Identificar()
    {
        Console.WriteLine($"{Nome} - {Email}");
    }
}

public class Aluno : Pessoa
{
    // de forma oculta, Aluno está herdando Nome, Email, Sexo e o método Identificar() da classe Pessoa
    public int NotaFinal;
    public bool Aprovado;
    public string? Curso { get; set; }
}

public class Coordenador : Pessoa
{
    public string? Turno { get; set; }
    private double Salario;
}

public class Professor : Pessoa
{
    public string? Disciplina { get; set; }
    private double Salario;
}