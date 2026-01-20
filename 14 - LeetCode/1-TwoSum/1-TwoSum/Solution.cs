/*
Objetivo: a partir de um array de inteiros, obter e retornar o índice de dois numeros que quando somados, resultam no alvo estabelecido.
*/

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        // criando o array que receberá os dois números que, somados, são iguais ao valor
        int[] TwoNumbers = new int[2];

        // criando variável de contagem para usar no foreach
        int i = 0;

        Console.WriteLine("Aray:");
        foreach (var number in nums)
        {
            Console.Write(number + " ");    
        }

        // primeiro foreach para rodar a cada número
        foreach (int firstNumberArray in nums)
        {
            // reiniciando o índice do segundo número a cada rodada
            int j = 0;

            // segundo foreach para rodar a verificação de soma comparando o número do primeiro foreach com os próximos no array
            foreach (int secondNumberArray in nums)
            {
                if ((i != j) && (firstNumberArray + secondNumberArray) == target)
                {
                    TwoNumbers = new int[] { i, j };
                    Console.WriteLine($"\n\nValor destino: {target}\n" +
                                      $"Números encontrados no array para a soma: {firstNumberArray} e {secondNumberArray}\n" +
                                      $"Índices: {i} e {j}");

                    return TwoNumbers; // encerra imediatamente ao encontrar o primeiro resultado
                }

                j++;
            }
            i++;
        }
        return TwoNumbers;
    }

    public static void Main()
    {
        TwoSum([2, 4, 5, 3, 5, 10], 6);
        Console.ReadKey();
    }
}