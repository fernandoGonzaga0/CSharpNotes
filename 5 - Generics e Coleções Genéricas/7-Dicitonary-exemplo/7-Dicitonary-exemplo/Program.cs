// Criando um sistema de Dictionary<int, Aluno> onde int será a chave de um aluno e Aluno será um dicionário contendo o nome e nota de alunos.
// Será possível adicionar alunos além dos 5 criados anteriormente.

using static MetodosFixos;

public class MetodosFixos
{
    // método para percorrer a chave/valores no dicionario
    public static void ExibirColecao(Dictionary<int, Aluno> alunos) // dicionário será o tipo de dado, alunos o dado em si
    {
        foreach(var item in alunos)
        {
            Console.WriteLine($"{item.Key} {item.Value.Nome} {item.Value.Nota}");
        }
    }

    //  método para corrigir nota
    public static void CorrigirNota()
    {
        do
        {
            Console.WriteLine("\nInsira o código do aluno (99 para sair): ");

            int codigo = Convert.ToInt32(Console.ReadLine());

            if (codigo == 99)
            {
                break;
            }

            var resultado = alunos.ContainsKey(codigo); // verificando se existe o código inserido no dicionário alunos, caso existir retornará true e a condicional será executada
            if (resultado)
            {
                Console.WriteLine("\nInforme a nota de 0 a 10: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                alunos[codigo].Nota = nota; // acessando o dicionário alunos, na posição do código inserido e atribuindo no value Nota, a nota inserida aqui no menu
            }
            else
            {
                Console.WriteLine("\nAluno não localiizado...");
            }
        }
        while (true);
        ExibirColecao(alunos);
    }

    // declaração de campo estático na classe MétodosFixos, indicando uma criação inicial do dicionário com 5 alunos
    public static Dictionary<int, Aluno> alunos = new Dictionary<int, Aluno>()
    {
          { 1, new Aluno("Maria", 7)},
            { 2, new Aluno("Fernando", 6)},
            { 3, new Aluno("José", 3)},
            { 4, new Aluno("Pedro", 6)},
            { 5, new Aluno("Mario", 8)}
        };
    }

    // criando classe Aluno 
    public class Aluno
    {

        public string Nome { get; set; }
        public int Nota { get; set; }
        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }
    }

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Alunos e Notas ---\n");

        // exibindo a coleção atual
        MetodosFixos.ExibirColecao(alunos);
        MetodosFixos.CorrigirNota();
    }
}