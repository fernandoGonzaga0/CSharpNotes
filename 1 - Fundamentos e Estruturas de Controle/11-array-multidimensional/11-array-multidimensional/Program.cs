/*
 
ARRAYS MULTIDIMENSIONAIS = array de arrays

São usados para trabalhar com arrays de forma tabular, com linhas e colunas de dados.
 
*/


using System;

class Program
{
    static void Main()
    {
        // criando array multidimensional (basicamente um arrays com dois arrays)
        int[,] numeros = { {1,3,5,7,9}, {2,4,6,8,10} };

        // acessando um elemento do array multidimensional (necessário acessar sua posição por linha x coluna)

        Console.WriteLine(numeros[1, 2]); //exibirá o número 6
        Console.WriteLine(numeros[0, 3]); //exibirá o número 7
    }
}