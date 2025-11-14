/*

Para lidar com exceções (situações onde o C# não espera um erro mas o encontra), a linguagem fornece o suporte interno através do uso do bloco try-catch. 

try 
{
    // código que vai ser executado e que pode gerar uma exceção
}
catch 
{
    // se ocorrer um erro será tratado aqui
}

*/

class Program
{
    static void Main()
    {
        // divisão de x/y visando tratativa de excessão no catch

        // x
        Console.WriteLine("Insira o valor de x: ");
        int x = Convert.ToInt32(Console.ReadLine());

        // y
        Console.WriteLine("Insira o valor de y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        try
        {
            int z = x / y;
            Console.WriteLine($"Divisão de {x} por {y} = {z}");
        } 
        catch (Exception ex) // ex poderia ser qualquer outro valor (é só um apontador). Exception é a classe base para tratar erros em C#. 
        {
            Console.WriteLine("Não existe divisão por zero, tente outro número...");

            Console.WriteLine($"\nErro: <<< {ex.Message} >>>"); // para exibir a mensagem do erro contendo o motivo
            Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}"); // para exibir o local do arquivo e linha do erro 
        }
//      finally
//      {
//          // código que pode ser parametrizado para exibição obrigatória
//      }

        Console.ReadKey();
    }
}
