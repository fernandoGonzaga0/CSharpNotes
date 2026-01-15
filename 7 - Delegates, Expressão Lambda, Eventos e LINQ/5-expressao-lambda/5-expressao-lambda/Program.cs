/*

As expressões lambda surgiram como uma evolução dos métodos anônimos, deixando o código mais legível, evitando a palavra DELEGATE e blocos desnecessários.

São muito usadas em LINQ, eventos e callbacks.

*/

// EXEMPLO SEM LAMBDA

class OperacaoSemLambda
{
    public delegate int Operacao(int x);

    static int Dobrar(int n) => n * 2;

    // Main() desabilitado para manter apenas um no código
    //static void Main()
    //{
    //    Operacao op = Dobrar;
    //    Console.WriteLine(op(5)); 
    //}

    // aqui criamos um método chamado Dobrar e associamos ao delegate
}

// EXEMPLO COM LAMBDA

class Program
{
    public delegate int Operacao(int x);

    static void Main()
    {
        // usando expressão lambda, significa -> receba n e retorne n*2
        Operacao op = (n => n * 2);
        Console.WriteLine(op(5));

        Console.ReadKey();
    }
}