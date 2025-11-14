// Ex - Criar um programa para receber 5 nomes de alunos e suas 5 notas. Acessar e exibir as notas e nomes

public class AcoesAlunos
{
    public static void InserirNomeAlunos(string?[] ArrayNomeAlunos)
    {
        for (int i = 0; i<ArrayNomeAlunos.Length; i++)
        {
            Console.Write($"Aluno {i + 1}: ");
            ArrayNomeAlunos[i] = Console.ReadLine();
        }
    }

    public static void ExibirNomeAlunos(string?[] nomeAlunos)
    {
        foreach (string? nomes in nomeAlunos)
        {
            Console.Write(nomes + " | ");
        }
    }

    public static void InserirNotaAlunos(double[] ArrayNotaAlunos)
    {
        for (int i = 0; i < ArrayNotaAlunos.Length; i++)
        {
            Console.Write($"\n{i + 1}° nota: ");
            ArrayNotaAlunos[i] = Convert.ToDouble(Console.ReadLine());
        }
    }

    public static void ExibirNotaAlunos(double[] notaAlunos)
    {
        foreach (double notas in notaAlunos)
        {
            Console.Write(notas + " | ");
        }
    }

    public static void MediaAritmetica(double[] ArrayNotaAlunos)
    {
        double soma = 0;
        for (int i = 0; i < ArrayNotaAlunos.Length; i++)
        {
            soma += ArrayNotaAlunos[i];
        }
        double mediaAr = soma / 5;
        Console.WriteLine($"{mediaAr}");

    }

}

public class Program
{
    static void Main()
    {
        // criando os dois arrays
        string?[] ArrayNomeAlunos = new string[5];
        double[] ArrayNotaAlunos = new double[5];

        // inserção dos nomes dos alunos
        Console.WriteLine("Inserção de dados dos alunos ->\n");
        AcoesAlunos.InserirNomeAlunos(ArrayNomeAlunos);
        Console.Write("\nAlunos -> ");
        AcoesAlunos.ExibirNomeAlunos(ArrayNomeAlunos); // chamada do método para exibição dos nomes

        // inserção das notas
        Console.WriteLine("\n\nInserção de notas dos alunos ->");
        AcoesAlunos.InserirNotaAlunos(ArrayNotaAlunos);
        Console.Write($"\nNotas ->");
        AcoesAlunos.ExibirNotaAlunos(ArrayNotaAlunos);

        // Inserção das combinações entre nome + nota
        Console.WriteLine("\n\n---- ALUNOS x NOTAS ----\n");
        for (int i = 0; i < ArrayNomeAlunos.Length; i++)
        {
            Console.WriteLine($"{i+1}) Aluno {ArrayNomeAlunos[i]} -> Nota: {ArrayNotaAlunos[i]}\n");
        }

        //  Exibição de média aritmética
        Console.Write("\nMédia aritmética das notas: ");
        AcoesAlunos.MediaAritmetica(ArrayNotaAlunos);

        Console.WriteLine("Finalizando processo...");
    }
}




