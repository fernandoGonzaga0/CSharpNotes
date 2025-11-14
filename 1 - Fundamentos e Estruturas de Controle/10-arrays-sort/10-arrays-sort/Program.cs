/*

ORDENANDO ARRAYS

Existem formas diferentes de se ordenar arrays, ex:

Sort() -> ordena um array alfabeticamente ou em ordem crescente

Min() -> retorna o menor valor
Max() -> retorna o maior valor
Sum() -> retorna a soma dos elementos se numéricos
 
*/

using System;

using System.Linq;

class Program
{
    static void Main()
    {
        int[] numeros = [4, 6, 2, 3];

        Array.Sort(numeros);
        Console.WriteLine(numeros);

        Console.WriteLine(numeros.Min());
        Console.WriteLine(numeros.Max());
        Console.WriteLine(numeros.Sum());
    }
}