/*

**** 
    Esse exemplo abaixo é feito levando em consideração classes genéricas 'abertas', onde o tipo não é definido. Isso não é o ideal em projetos longos.
    Permitir que o usuário consiga inserir dados de tipos diferentes faz com que o desempenho seja afetado, o ideal é sempre definir nas classes e métodos o tipo esperado.
****

O recurso Generics permite que classes, métodos e interfaces possam ser parametrizados por tipo. 

Um tipo genérico é declarado especificando um parâmetro de tipo -> NomeTipo<T> onde T é o parâmetro de tipo.

Generics é usado no namespace System.Collection.Generic

 */

                                                                        // Sem generics

// o código abaixo possui dois métodos na classe Teste, um para comparar inteiros e outro para floats
public class Teste
{
    // comparação de inteiros
    public void CompararInt(int p1, int p2)
    {
        var resultado = p1.Equals(p2); // p1 == p2 retornando boolean
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }

    // comparação de floats
    public void CompararFloat(float p1, float p2)
    {
        var resultado = p1.Equals(p2); // p1 == p2 retornando boolean
        Console.WriteLine($"{p1} e {p2} são iguais ? {resultado}");
    }

    // comparação de decimals
    public void CompararDecimals(decimal d1, decimal d2)
    {
        var resultado = d1.Equals(d2);
        Console.WriteLine($"{d1} e {d2} são iguais? {resultado}");
    }
} 

                                                                        // Com generics

// No código acima foi necessário codar dois construtores na classe Teste, uma para inteiros e outra para floats.
// Generics atua nesse sentido, apoiando na criação de métodos/classes/strucs genéricos que podem generalizar sua utilização.
public class TesteGenerics
{
    // método genérico, aceita em T todo tipo de dado (se fosse necessário validar mais de um tipo, poderia usar T1 p1, T2 p2, T3 p3... sem problemas
    // vou utilizar dois tipos (T1 e T2) apenas para comparar por final componentes de tipos diferentes
    public void Comparar<T1, T2>(T1 p1, T2 p2)
    {
        // apenas para complementação, vou validar os tipos do que é inserido antes de comparar
        Console.WriteLine($"Tipos de p1 e p2: {p1.GetType()} e {p2.GetType()}\n");
        var resultado = p1.Equals(p2);
        Console.WriteLine($"{p1} e {p2} são iguais? {resultado}\n---------------------------------------------------------------------");
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
        teste2.Comparar(s1, i4);

        Console.ReadKey();
    }
}