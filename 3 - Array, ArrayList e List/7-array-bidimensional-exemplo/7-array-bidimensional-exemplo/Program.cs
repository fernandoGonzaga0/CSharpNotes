/*
 
Declare e aloque memória para um array de strings chamado alunos com 2 linhas e 5 colunas.

i) inicializar o array com dados referente aos nomes dos alunos recebidos via teclado informando o índice da linha e coluna de cada elementol
ii) exibir no console os dados informados no array bem como o índice da linha e coluna de cada elemento; 
 
*/


public static class Program 
{
    public static void Main()
    {
        // declarando array e alocando memória para 2 linhas e 5 colunas
        string?[,] alunos = new string[2,5];

        Console.WriteLine("----- ARRAY BIDIMENSIONAL ALUNOS -----\n");
        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            for (int j = 0; j < alunos.GetLength(1); j++)
            {
                Console.WriteLine($"Posição do aluno: [{i}, {j}]. Nome: ");
                alunos[i, j] = Console.ReadLine();
            }
        }

        Console.WriteLine($"\nDados dos alunos: ");

        for (int i = 0; i < alunos.GetLength(0); i++)
        {
            for (int j = 0; j < alunos.GetLength(1); j++)
            {
                Console.WriteLine($"[{i}, {j}] - {alunos[i, j]}");
            }
        }

    } 
}