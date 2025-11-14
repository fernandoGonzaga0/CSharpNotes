/*
 
METHODS == FUNCTIONS

Um método (função) é um bloco de código que é executado apenas quando chamado.

Utilizado para reúso de código, visto que uma vez feito, pode ser utilizado dversas vezes.

Main() é um método frequentemente utilizado. A sintaxe de métodos/funções é a seguinte:

    static void methodName() 
        {

         // código a ser executado                

        }

void = significa que o método não possui um retorno válido.
static = significa que o método pertence à classe Program e não à um objeto da classe Program e não precisa ser instanciado para ser chamado

*/

using System;

class Program
{
    static void MeuMetodo()
    {
        Console.WriteLine("Método executado com sucesso!");
    }

    static void Main()
    {
        Console.WriteLine("Testando método...\n");
        MeuMetodo();
    }
}