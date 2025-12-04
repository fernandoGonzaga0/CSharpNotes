/*

No C#, Task representa uma tarefa assíncrona que pode estar em execução, concluída ou ainda aguardando.

Task → usado quando não há retorno (como void, mas assíncrono).

Task<T> → usado quando a tarefa retorna um valor do tipo T.

A programação assíncrona é implementada usando a classe Task do namespace System.Threading.Tasks.

A classe Task é uma representação assíncrona de uma operação em execução e é usada para executar tarefas assíncronas de uma operação em execução e é usada para executar tarefas assíncronas.

O núcleo da programação assíncrona são objetos Task e Task<T>, que modelam as operações assíncronas. Esses objetos oferecem suporte às palavras-chave async e await.

Await -> usado para aguardar uma operação que retorna um Task ou Task<T>
Async -> usado para sinalizar que um método é assíncrono

*/

// Exemplo de Task (sem retorno): Main() aguardará a finalização de ExecutarTarefa() para concluir a execução.

using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await ExecutarTarefa(); // await pausa a execução do método Main até que a Task retornada por ExecutarTarefa() seja concluída. 
        Console.WriteLine("Programa finalizado!");
    }
    static async Task ExecutarTarefa()
    {
        Console.WriteLine("Iniciando tarefa...");
        await Task.Delay(2000); // simula trabalho demorado
        Console.WriteLine("Tarefa concluída!");
    }
}