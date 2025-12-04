// SISTEMA DE AVALIAÇÃO DE ALUNOS

/*

1° - Classe chamada Sistema de Avaliação
2° - Método Main() deverá usar os métodos abaixo para calcular a média e classificar um aluno
3° - Primeiro método: média ponderada para calcular a média final do aluno (usar double)
4° - Segundo método: classificar aluno (aprovado, recuperação ou reprovado)
5° - Terceiro método: imprimir resultado (nome, média e status)

OBS: tradicionalmente o método Main() é executado em uma classe Program exclusiva

*/

using _14_methods_sistemaAvaliacao; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o nome do aluno: \n");
        string? nomeAluno = Console.ReadLine();
        Console.WriteLine("\nInsira a nota 1: \n");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira a nota 2: \n");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira a nota 3: \n");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double p1 = 2, p2 = 3, p3 = 1;

        double mediaFinal = SistemaAvaliacao.CalcularMediaPonderada(nota1, p1, nota2, p2, nota3, p3);

        string statusAluno = SistemaAvaliacao.ClassificarAluno(mediaFinal);

        SistemaAvaliacao.ExibirResultado(nomeAluno, mediaFinal, statusAluno);
    }
}