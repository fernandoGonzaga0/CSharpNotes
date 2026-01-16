/*

Se o método assíncrono criar várias tarefas (Task) ou usar o método Task.WhenAll, todas as exceções ocorridas serão capturadas em uma instância de AggregateException. 

Aguardar (await) a instância de Task, usando apenas o bloco try-catch, vai obter apenas a primeira exceção, mesmo que várias exceções possam ter sido lançadas em seu método assíncrono. A palavra-chave await vai desempacotar apenas a primeira exceção da instância Task e desta forma não vamos obter todas as exceções lançadas.

Para resolver esse problema e obter todas as exceções lançadas, podemos usar a propriedade InnerExceptions da classe AggregateException, que representa um ou mais erros que ocorrem durante a execução do método assíncrono. A classe AggregateException herda da classe Exception e contém uma propriedade chamada InnerExceptions, que é uma coleção de exceções que foram lançadas durante a execução assíncrona. 

Assim, basta iterar através das exceções individuais usando a propriedade InnerExceptions.
 
*/

await LancaMultiplasExcecoesAsync();

Console.ReadKey();

static async Task LancaMultiplasExcecoesAsync()
{
    Task? tarefas = null;
    try
    {
        var primeiraTask = Task.Run(() => {
            Task.Delay(1000);
            throw new IndexOutOfRangeException("IndexOutOfRangeException lançada explicitamente.");
        });
        var segundaTask = Task.Run(() =>
        {
            Task.Delay(1000);
            throw new InvalidOperationException("InvalidOperationException lançada explicitamente.");
        });

        tarefas = Task.WhenAll(primeiraTask, segundaTask);
        await tarefas;
    }
    catch
    {
        Console.WriteLine("Ocorreram as seguintes exceções: \n");
        AggregateException TodasExceptions = tarefas.Exception;

        foreach (var ex in TodasExceptions.InnerExceptions)
        {
            Console.WriteLine(ex.GetType().ToString());
        }
    }
}