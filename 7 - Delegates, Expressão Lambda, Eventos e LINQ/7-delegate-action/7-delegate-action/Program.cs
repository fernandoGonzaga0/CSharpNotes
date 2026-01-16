/*

O que é Delegate Action?

Action é um delegate genérico, se diferenciando por não retornar nada. Ele serve para representar métodos que executam uma ação, mas não precisam devolver resultado.

Assinaturas possíveis:

    Action -> não recebe parâmetros, não retorna nada
    Action<T> -> recebe 1 parâmetro do tipo T, não retorna nada
    Action<T1, T2, ...> ->  pode receber até 16 parâmetros, todos retornando void

Por que existe?

Antes do Action, era necessário criar delegates personalizados sempre que quisesse passar métodos que não retornam nada.

*/

// EXEMPLO SEM USAR ACTION

    // aqui criamos um delegate manualmente para representar um método que não retorna nada

//class Program
//{
//    // delegate manual
//    public delegate void MostrarMensagem(string msg);

//    static void Exibir(string texto)
//    {
//        Console.WriteLine(texto);
//    }

//    static void Main()
//    {
//        MostrarMensagem handler = Exibir;
//        handler("Usando delegate manual!");
//    }
//}

// EXEMPLO COM ACTION
    
    // aqui não precisamos criar um delegate manual, o Action<string> já soluciona o cenário

    class Program
    {
        static void Main()
        {
            // usando Action<string> 
            Action<string> handler = (texto => Console.WriteLine(texto));

            handler("Usando action!");
        }
    }