/*

Um  método anônimo é aquele que não possui nome e que pode ser definido usando a palavra-chave delegate e pode ser atribuída a uma variável do tipo delegate. 

É usado para que não seja necessário criar um método e instanciá-lo para realizar sua chamada.

Útil quando a função é usada apenas uma vez.

Na prática, o que muda?

    i) Método nomeado: você precisa criar um método separado e depois associá-lo ao delegate.
    ii) Método anônimo: você escreve a lógica diretamente no ponto de uso, sem criar um método extra.

*/

// EXEMPLO COM MÉTODO ANÔNIMO

using System;

class Program
{
    // definição de um delegate
    public delegate void MostrarMensagem(string msg);

    static void Main()
    {
        // criando um método anônimo diretamente no delegate
        MostrarMensagem handler = delegate(string texto)
        {
            Console.WriteLine(texto);
        };

        handler("Usando método anônimo!");
    }
}

// nesse caso, não é necessário criar o método Exibir, pois a lógica está embutida no delegate

// EXEMPLO SEM MÉTODO ANÔNIMO 

//class Program
//{
//    // definição de um delegate
//    public delegate void MostrarMensagem(string msg);

//    // método "normal" que será usado pelo delegate
//    static void Exibir(string texto)
//    {
//        Console.WriteLine(texto);
//    }

//    static void Main()
//    {
//        // associando o método ao delegate
//        MostrarMensagem handler = Exibir;

//        // chamando o delegate
//        handler("Usando método nomeado!");
//    }
//}