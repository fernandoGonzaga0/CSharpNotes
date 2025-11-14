/*
 
Um tipo genérico é declarado especificando um parâmetro de tipo -> NomeTipo<T> onde T é o parâmetro de tipo.

Generics é usado no namespace System.Collection.Generic

 */

                                                                        // Sem generics
/*
 
// classe Teste
public class Teste
{
    // comparação de inteiros
    public void Comparar(int p1, int p2)
    {
        var resultado = p1.Equals(p2); // p1 == p2 retornando boolean
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }

    // comparação de floats
    public void Comparar(float p1, float p2)
    {
        var resultado = p1.Equals(p2); // p1 == p2 retornando boolean
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }
} 
*/

                                                                        // Com generics

// No código acima foi necessário codar dois construtores na classe Teste, uma para inteiros e outra para floats.
// Generics atua nesse sentido, apoiando na criação de métodos/classes/strucs genéricos que podem generalizar sua utilização.
public class TesteGenerics
{
    public void Comparar<T>(T p1, T p2) // método genérico, aceita em T todo tipo de dado (se fosse necessário validar mais de um tipo, poderia usar T1 p1, T2 p2, T3 p3... sem problemas
    {
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
    }
}

public class Program
{
    static void Main()
    {
        string s1 = "Fernando";
        string s2 = "Fernando";

        int i3 = 6;
        int i4 = 9;

        float f5 = 111;
        float f6 = 111;

        TesteGenerics teste2 = new();

        teste2.Comparar(s1, s2);
        teste2.Comparar(i3, i4);
        teste2.Comparar(f5, f6);
    }
}