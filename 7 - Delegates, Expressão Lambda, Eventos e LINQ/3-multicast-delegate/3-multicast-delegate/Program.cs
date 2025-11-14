/*

Multicast delegate: delegate que referencia e invoca MAIS de um método.

Criar um tipo seguro que representa métodos com uma determinada assinatura, permitindo que você referencie, armazene e invoque métodos dinamicamente

 
*/


MeuDelegate delegateMulticast = new MeuDelegate(Metodo1);
delegateMulticast += Metodo2; // add métodos no delegate (é possível remover usado -=)
delegateMulticast += Metodo3; 

delegateMulticast("Olá, multicast delegate!");

Console.ReadKey();

static void Metodo1(string mensagem)
{
    Console.WriteLine("Método 1: " + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Método 2: " + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Método 3: " + mensagem);
}

public delegate void MeuDelegate(string mensagem);