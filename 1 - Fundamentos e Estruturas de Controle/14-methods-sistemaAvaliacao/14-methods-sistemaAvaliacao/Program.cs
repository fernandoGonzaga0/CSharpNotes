// SISTEMA DE AVALIAÇÃO DE ALUNOS

/*

1° - Classe chamada Sistema de Avaliação
2° - Método Main() deverá usar os métodos abaixo para calcular a média e classificar um aluno
3° - Primeiro método: média ponderada para calcular a média final do aluno (usar double)
4° - Segundo método: classificar aluno (aprovado, recuperação ou reprovado)
5° - Terceiro método: imprimir resultado (nome, média e status)

OBS: tradicionalmente o método Main() é executado em uma classe Program exclusiva
 
*/

class SistemaAvaliacao
{
    public static double CalcularMediaPonderada(double nota1, double peso1, double nota2, double peso2, double nota3, double peso3)
    {
        double mediaFinal = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / (peso1 + peso2 + peso3) ;
        return Math.Round(mediaFinal, 2);
    }    

    // observar que o retorno da função double CalcularMediaPonderada é, de fato, um double
    // sua entrada (parametro) também está em double


    public static string ClassificarAluno(double media)
    {
        if (media >= 6)
        {
            return "Aprovado";
        } 
        else if (media >= 3) // automaticamente menor que 6
        {
            return "Recuperação";
        }
        else
        {
            return "Reprovado";
        }
    }

    // observar que o retorno da função string ClassificarAluno é, de fato, uma string
    // sua entrada (parametro) está em double


    public static void ExibirResultado(string nome, double media, string status)
    {
        Console.WriteLine("----- Relatório do Aluno -----");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Status: {status}");
        Console.WriteLine("------------------------------\n");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o nome do aluno: \n");
        string nomeAluno = Console.ReadLine();
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