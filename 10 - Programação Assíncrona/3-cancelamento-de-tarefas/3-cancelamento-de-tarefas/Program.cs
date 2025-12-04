/*

A plataforma .NET usa um modelo unificado para cancelamento cooperativo de operações assíncronas ou síncronas de longa duração.

Este modelo é baseado em um objeto leve chamado token de cancelamento. 
 
*/

using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // criando um controlador de cancelamento
        var cts = new CancellationTokerSouce();
        var token = cts.Token;

        // iniciando uma tarefa longa
        var tarefa = Task.Run(async () =>
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancelamento solicitado!");
                return;
            }

            Console.WriteLine($"Número: {i}");
            await Task.Delay(200);
        }
        }, token);


        
        )
    }
}