// Podemos usar o laço foreach para ler e recuperar elementos de um array sem precisar usar o índice nem definir o tamanho do array

// A instrução foreach permite executar uma instrução ou bloco de instruções para cada elemento presente em uma coleção.

// Não precisa de inicialização nem parada

class Program
{
    static void Main()
    {
        int[] numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12];

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}