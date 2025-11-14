/*
 
Escreva um programa para adicionar dois números inteiros usando o conceito Generics.
 
*/

using System.Numerics;

public class AddGenerics
{
    public static void Adicionar<T>(T numero1, T numero2) where T : INumber<T>
    {
        Console.WriteLine($"Soma entre os números: {numero1+numero2}");
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine("--- SOMA ---");
        Console.WriteLine("\nInsira o primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInsira o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        AddGenerics.Adicionar(n1, n2);
    }
}