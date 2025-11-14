// Nesse exemplo semelhante ao anterior, vamos inserir um objeto como parâmetro no método Resultado (classe Curso). Tal objeto pertencerá à classe Aluno.

public class Aluno
{
    // imaginando um cenário onde tenhamos milhares de atributos (atualmente existem 4), inserir o próprio objeto gerado dessa classe Aluno no parâmetro
    // do método Resultado facilita bastante a codificação
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(Aluno aluno1) // ao invés de usarmos "string nome, int idade, string sexo, string aprovado", inserimos o objeto gerado em Main()
    {
        Console.WriteLine($"\nO aluno {aluno1.Nome}, sexo: {aluno1.Sexo} com {aluno1.Idade} anos");

        if (aluno1.Aprovado == "S")
        {
            Console.Write(" foi aprovado.");
        }
        else
        {
            Console.Write(" foi reprovado.");
        }
    }
}

// Com as duas classes criadas, vamos fazer a relação entre os componentes de Aluno com o método Resultado na classe Curso.

class Program
{
    static public void Main()
    {
        // Obtendo os dados do aluno (nome, idade, sexo e se está aprovado)
        Aluno aluno1 = new();
        Console.WriteLine("Nome: ");
        aluno1.Nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        aluno1.Idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        aluno1.Sexo = Console.ReadLine();
        Console.WriteLine("Aprovado (S)im  (N)ão : ");
        aluno1.Aprovado = Console.ReadLine();

        Curso cursoInstanciado = new(); // aqui importamos a classe Curso e conseguimos posteriormente conectar ao método Resultado
        cursoInstanciado.Resultado(aluno1); // ao invés de usar ".Nome, aluno1.Idade, aluno1.Sexo, aluno1.Aprovado", chamaremos o próprio objeto
    }
}