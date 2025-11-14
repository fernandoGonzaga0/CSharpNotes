/*

Um  método anônimo é aquele que não possui nome e que pode ser definida usando a palavra-chave delegate e pode ser atribuída a uma variável do tipo delegate. 

É usado para que não seja necessário criar um método e instanciá-lo para realizar sua chamada.
 
*/

public delegate void Imprimir(int valor);

public class Program
{
    public static void Main()
    {
        Imprimir imp1 = delegate (int valor) // declarando um método anônimo usando a sintaxe delegate(int valor){...}
        {
            Console.WriteLine($"Método anônimo. Valor: {valor}");
        };

        imp1(240);

        Console.ReadKey();
    }
}

/*

EXEMPLO SEM MÉTODO ANÔNIMO 

using System;

public delegate void Imprimir(int valor);

public class Program
{
    // Método nomeado compatível com o delegate
    public static void MostrarValor(int valor)
    {
        Console.WriteLine($"Método nomeado. Valor: {valor}");
    }

    public static void Main()
    {
        // Referenciando o método nomeado
        Imprimir imp1 = MostrarValor;

        imp1(240); // Invoca o método MostrarValor

        Console.ReadKey();
    }
} 
 
*/