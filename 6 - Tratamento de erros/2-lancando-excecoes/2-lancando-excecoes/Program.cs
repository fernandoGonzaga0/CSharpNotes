/*
 
Lançando exceções -> uma exceção pode se lançada explicitamente usando a instrução throw seguida por uma instância de uma classe de exceção com Exception ou uma de suas classes derivadas.

throw new Exception();

throw new Exception("Lançamento manual de exceção");
 
*/

public class Program
{
    static void Main(string[] args)
    {
        // tratando o erro na classe A
        try
        {
            A.ProcessarA(); // chamando o método
        }
        catch (Exception ex) 
        {
            Console.WriteLine("\nTratando o erro em Main\n");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}

class A
{
    public static void ProcessarA()
    {
        B.ProcessarB();
    }
}

class B
{
    public static void ProcessarB()
    {
        C.ProcessarC();
    }
}

class C
{
    public static void ProcessarC()
    {
        throw new NotImplementedException("Método não implementado!");    
        // nesse momento, o fluxo de execução do código é transferido para o gerenciamento de excessões do VS Code 2022
        // para ficar relançando essa mesma excessão no código, basta inserir throw; dentro de catch nas outras classes
    }
}