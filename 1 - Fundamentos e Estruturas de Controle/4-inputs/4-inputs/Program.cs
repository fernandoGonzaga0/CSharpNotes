/*
 
 INPUTS

Para receber entradas de usuários, é comum utilizar o Console.ReadLine().

Para números, o Console.ReadLine() é utilizado diretamente em uma conversão para numeral (ex: int).
 
 */

namespace System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Insira sua idade:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Dados:\n\nNome: {nome}\nIdade: {idade}");
    }
}