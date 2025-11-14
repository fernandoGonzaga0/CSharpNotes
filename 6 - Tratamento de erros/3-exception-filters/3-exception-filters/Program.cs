/*

O recurso Exception Filters foi introduzido na versão 6.0 do C# e permite executar blocos try/catch com base em uma condição específica quando ocorre uma exceção. 

Isso significa que em um bloco try/catch, com vários blocos catch, podemos decidir qual bloco catch deverá ser executado segundo um critério pré-definido, especificando uma condição no bloco catch.

Um bloco catch será executado somente quando a condição for verdadeira. Se a condição for falsa, o bloco catch é ignorado e o compilador procura o próximo manipulador catch. 
 
Sintaxe: 

try
{
    // código passível de erro
}
catch (Exception e) when (Filtro/Critério/Condição)
{
    // ação
}

*/
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("\nInforme o dividendo:");
            int dividendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nInforme o divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int resultado = (dividendo / divisor);

            Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
        }

        catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Friday) // capturando o dia (e hora) da ocorrência e validando se ela aconteceu numa sexta
        {
            Console.WriteLine("\nHoje é sexta-feira e não capturamos estas exceções. Voltaremos na segunda!");
        }

        catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Monday) // capturando o dia (e hora) da ocorrência e validando se ela aconteceu numa sexta
        {
            Console.WriteLine("\nO erro será tratado. Dia de expediente: Segunda feira");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        Console.ReadKey();
    }

}