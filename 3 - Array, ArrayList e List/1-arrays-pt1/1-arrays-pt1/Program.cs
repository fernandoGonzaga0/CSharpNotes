/*
 
Arrays -> são um conjunto de elementos de mesmo tipo de dados e tamanho fixo.

Um array de uma dimensão é um vetor;

Um array de mais de uma dimensão é uma matriz.
 
Por que usar? Serve para armazenar diversos valores em uma mesma variável.

Sintaxe -> TipoDados[] NomeDoArray; -> int[] numeros = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

*/

int[] numeros = [ 1, 2, 6, 8, 12 ]; // alocando a memória do array

Console.WriteLine("\n--- Arrays ---\n");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Posição: {i}, valor: {numeros[i]}\n");
}
