/*
 
Dada uma classe Aluno definida com duas propriedades (Nome e Nota), crie uma lista de objetos do tipo Aluno usando a coleção List<T> com os seguintes dados que representam
o nome a nota do aluno.

A seguir, realize as seguintes operações na lista de objetos Aluno criada:

i) crie um método para exibir a lista de alunos com nome e nota, a média, aritmética das notas e a quantidade de alunos na lista
ii) inclua na lista original os alunos: Bia - 7.75 e Mario - 8.95 e exiba novamente a lista de alunos
iii) localize na lista o aluno com nome 'Amanda' e a seguir remova este aluno da lista e exiba novamente a lista de alunos
iv) ordene a lista pelo nome do aluno e exiba a lista ordenada
v) obtenha e exiba no console os alunos aprovados e reprovados
 
*/

using _32_exercicio_List;

internal class Program
{
    internal static void Main()
    {
        Console.WriteLine("--- Notas de Alunos ---\n");
        Metodos.ExibeAlunos();

        Console.WriteLine("\nAdicionando dois alunos...\n");
        Aluno.alunos.Add(new Aluno { Nome = "Bia", Nota = 7.75 });
        Aluno.alunos.Add(new Aluno { Nome = "Mario", Nota = 8.89 });
        Metodos.ExibeAlunos();

        Console.WriteLine("\nRemovendo aluna Amanda...\n");
        Aluno.alunos.RemoveAll(a => a.Nome == "Amanda");
        Metodos.ExibeAlunos();

        Console.WriteLine("\nOrdenando alunos por nome:\n");
        Aluno.alunos.Sort((a, b) => a.Nome.CompareTo(b.Nome)); // CompareTo faz parte da interface IComparable
        Metodos.ExibeAlunos();

        Console.WriteLine("\nOrdenando alunos por nota crescente:\n");
        Aluno.alunos.Sort((a, b) => b.Nota.CompareTo(a.Nota));
        Metodos.ExibeAlunos();

        Console.WriteLine("\nOrdenando alunos por nota decrescente:\n");
        Aluno.alunos.Sort((b, a) => b.Nota.CompareTo(a.Nota));
        Metodos.ExibeAlunos();

        Console.WriteLine("\nAlunos APROVADOS ( nota >= 7)\n");
        List<Aluno> aprovados = new List<Aluno>(Aluno.alunos);
        aprovados.RemoveAll(a => a.Nota < 7);
        foreach (var aluno in aprovados)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
        }

        Console.WriteLine("\nAlunos REPROVADOS (nota < 7");
        List<Aluno> reprovados = new List<Aluno>(Aluno.alunos);
        reprovados.RemoveAll(r => r.Nota >= 7);
        foreach(var alunos in reprovados)
        {
            Console.WriteLine($"Aluno: {alunos.Nome}, Nota: {alunos.Nota}");
        }

        Console.ReadKey();
    }
}