/*

Multicast delegate: delegate que referencia e invoca MAIS de um método.

Criar um tipo seguro que representa métodos com uma determinada assinatura, permitindo que você referencie, armazene e invoque métodos dinamicamente

*/

using System;

public class Program
{
    public static void Metodo1(string mensagem)
    {
        Console.WriteLine("Método 1: " + mensagem);
    }

    public static void Metodo2(string mensagem)
    {
        Console.WriteLine("Método 2: " + mensagem);
    }

    public static void Metodo3(string mensagem)
    {
        Console.WriteLine("Método 3: " + mensagem);
    }

    public delegate void MeuDelegate(string mensagem);

    public static void Main()
    {
        MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
        delegateMulticast += Metodo2; // add métodos no delegate (é possível remover usando -=)
        delegateMulticast += Metodo3; 
        delegateMulticast("Olá, multicast delegate!");

        Console.ReadKey();
    }
}