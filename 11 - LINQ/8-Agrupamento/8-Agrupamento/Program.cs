/*

O agrupamento é um dos recursos mais poderosos da LINQ, podemos agrupar das seguintes formas:

- usando uma única propriedade;
- pela primeira letra de uma propriedade;
- usando um intervalo numérico calculado;
- usando um predicado booleano ou outra expressão;
- usando uma chave composta;

GroupBy -> agrupa por um determinado valor
GrupyBy com mútiplas chaves -> agrupa por várias chaves e retorna dados anônimos.

*/

public class Aluno
{
    public int Id { get; set; }
    public string? Curso { get; set; }
    public string? Nome { get; set; }
    public int Idade;

    public static List<Aluno> GetAlunos()
    {
        List<Aluno> alunos = new()
        {
            new Aluno() { Id = 1, Curso = "Fisica", Nome = "Fernando", Idade = 25},
            new Aluno() { Id = 2, Curso = "Matemática", Nome = "Julia", Idade = 25},
            new Aluno() { Id = 3, Curso = "Português", Nome = "Paulo", Idade = 22},
            new Aluno() { Id = 4, Curso = "Fisica", Nome = "Sara", Idade = 26},
            new Aluno() { Id = 5, Curso = "Biologia", Nome = "Vitor", Idade = 22},
            new Aluno() { Id = 6, Curso = "Fisica", Nome = "Savio", Idade = 22},
            new Aluno() { Id = 7, Curso = "Matemática", Nome = "Patricia", Idade = 21},
            new Aluno() { Id = 8, Curso = "Português", Nome = "Pedro", Idade = 27},
            new Aluno() { Id = 9, Curso = "Fisica", Nome = "Henrique", Idade = 20},
            new Aluno() { Id = 10, Curso = "Biologia", Nome = "Gabriela", Idade = 22}
        };
        return alunos;
    }
}

public class Program
{
    static void Main()
    {
        // obtendo os alunos
        var alunos = Aluno.GetAlunos();
        
        // criando o grupo por sala e ordenando por curso
        var grupoPorSala = alunos.GroupBy(a => a.Curso);

        Console.WriteLine("Grupos por Sala: ");

        foreach (var grupo in grupoPorSala) // iterando em cada grupo 
        {
            Console.WriteLine($"\nSala: {grupo.Key} | Alunos: {grupo.Count()}"); // mostra a sala e a quantidade de alunos
            // iterando a cada aluno do grupo
            foreach (var aluno in grupo)
            {
                Console.WriteLine($"\tId: {aluno.Id}, Nome: {aluno.Nome}, Idade: {aluno.Idade}");
            }
        }
    }
    
}