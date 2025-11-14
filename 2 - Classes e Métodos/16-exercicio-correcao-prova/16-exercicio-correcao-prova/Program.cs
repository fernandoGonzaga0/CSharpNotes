/*

Cada aluno tem uma nota inicial, o método receberá essa nota por referência e fará o seguinte:

          +1pt se for menor que 6, +0.5pt se estiver entre 6 e 8, manter a nota se maior que 8
 
*/
 
class CorrecaoProva
{
    public static void CorrigirNota(ref double nota, string? nome)
    {
        if (nota < 6)
        {
            Console.WriteLine($"Aluno {nome} -> Nota atual: {nota} + 1");
            nota = nota + 1;
            Console.WriteLine($"Nota corrigida: {nota}\n");
        } 
        else if (nota < 8)
        {
            Console.WriteLine($"Aluno {nome} -> Nota atual: {nota} + 0.5");
            nota = nota + 0.5;
            Console.WriteLine($"Nota corrigida: {nota}\n");
        } 
        else
        {
            Console.WriteLine($"Aluno {nome} -> Nota atual: {nota}.\nNão foi necessária a correção.");
        }
    }

    public static void Main()
    {
        Console.WriteLine("----- SISTEMA DE CORREÇÃO -----");

        Console.WriteLine("Insira o nome do aluno 1: ");
        string? nomeAluno1 = Console.ReadLine();

        Console.WriteLine("Insira a nota do aluno 1: ");
        double notaAluno1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o nome do aluno 2: ");
        string? nomeAluno2 = Console.ReadLine();

        Console.WriteLine("Insira a nota do aluno 2: ");
        double notaAluno2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira o nome do aluno 3: ");
        string? nomeAluno3 = Console.ReadLine();

        Console.WriteLine("Insira a nota do aluno 3: ");
        double notaAluno3 = Convert.ToDouble(Console.ReadLine());

        CorrigirNota(ref notaAluno1, nomeAluno1);
        CorrigirNota(ref notaAluno2, nomeAluno2);
        CorrigirNota(ref notaAluno3, nomeAluno3);
    }
}
