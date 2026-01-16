/*

O que é?

É um delegate genérico da biblioteca .NET. A assinatura é -> public delegate bool Predicate<T>(T obj);
Ele recebe um objeto do tipo T e retorna um bool.
Útil para testar uma condição sobre um objeto (verdadeiro ou falso). Usado em métodos como List<T>.Find, List<T>.Exists, List<T>.RemoveAll, etc. 

Por que existe? 

Antes, era necessário criar delegates personalizados para cada tipo de teste, sendo necessário para cada tipo diferente de verificação. Com o Predicate<T>, como
o tipo é genérico, pode abranger  um leque maior de informações e reduzir o código.

*/

// Ex: filtrar números maiores que 10

// EXEMPLO SEM PREDICATE, SENDO NECESSÁRIO CRIAR UM MÉTODO QUE ACEITE INT APENAS

//class Program
//{
//    static bool MaiorQueDez(int numero)
//    {
//        return numero > 10;
//    }

//    static void Main()
//    {
//        List<int> numeros = new List<int> { 4, 2, 15, 24, 5, 10, 20, 144 };

//        // usando método normal para encontrar o primeiro número maior que 10
//        int resultado = numeros.Find(MaiorQueDez);

//        Console.WriteLine(resultado);
//    }
//}

// EXEMPLO COM PREDICATE

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 2, 4, 7, 8, 10, 14, 25};

        // criando predicate 
        Predicate<int> condicao = (numero => numero > 10);

        // usando o predicate no método find
        int resultado = numeros.Find(condicao);

        Console.WriteLine(resultado);

        Console.ReadKey();
    }
}