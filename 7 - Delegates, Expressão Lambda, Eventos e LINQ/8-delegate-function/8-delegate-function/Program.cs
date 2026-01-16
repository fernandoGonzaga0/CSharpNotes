/*

O que é o delegate Func?

    Func é um delegate genérico que permite o retorno de qualquer tipo.

Assinatura:

    public delegate TResult Func<int T, out TResult>(T arg);

    i) Func<T, TResult> -> recebe um parâmetro T e retorna TResult
    ii) Existem variações até Func<T1, T2, ..., TResult> com até 16 parâmetros
    iii) Sempre retorna algo, não pode ser void

Por que existe?

    Antes do Func, você teria que criar delegates personalizados para cada caso em que um método retornasse algum valor.

*/

// EXEMPLO SEM USAR FUNC

    // Aqui criamos um delegate manualmente para representar um método que retorna algo
    // Aqui criamos também o próprio delegate Operacao

class Program
{
    public delegate int Operacao(int x);

    static int Dobrar(int n)
    {
        return n * 2;
    }

    static void Main()
    {
        Operacao op = Dobrar;
        Console.WriteLine(op(5));
    }
}
