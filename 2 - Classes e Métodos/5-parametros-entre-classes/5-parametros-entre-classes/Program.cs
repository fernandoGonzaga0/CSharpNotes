/*
 
Supondo que existam duas classes distintas. É possível fazer com que os campos (propriedades) de uma sejam usados alimentando parâmetros em outra classe.

Ex: no exemplo abaixo, vamos criar um objeto da classe Aluno e atribuir valores aos atributos da classe. Vamos então acessar o método Resultado da classe Curso
e passar os valores para o método.
 
*/
namespace Curso;
public class Aluno
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"\nO aluno {nome}, sexo: {sexo} com {idade} anos");

        if (aprovado == "S")
        {
            Console.WriteLine(" foi aprovado.");
        } else
        {
            Console.WriteLine(" foi reprovado.");
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
        cursoInstanciado.Resultado(aluno1.Nome,  aluno1.Idade, aluno1.Sexo, aluno1.Aprovado);
    }
}