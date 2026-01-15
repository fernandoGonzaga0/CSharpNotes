/*

Definição da palavra delegate: delegar um trabalho a outra pessoa que vai fazê-lo em seu lugar.

Um delegate é um tipo (como int, double, string, etc.) que representa referências a métodos. Ou seja, ele funciona como 'ponteiro' para a função seguro e orientado a objetos.

Para vincular um método ao delegate, dois parâmetros devem ser atendidos: 

                                                                        o tipo de retorno deve ser igual no delegate e no método; 
                                                                        o parâmetro usado no método deve ser igual ao parâmetro usado no delegate;

Em resumo:

    i) você pode armazenar um método dentro de um delegate;
    ii) depois, pode chamar esse método através do delegate, sem precisar saber qual método exatamente está sendo usado;

Há 3 etapas envolvidas ao trabalhar com delegates:

1) Declarar um delegate;
2) Definir um método de destino;
3) Invocar/chamar o delegate.

Sintaxe -> [modificador de acesso] delegate [tipo de retorno] [nome do delegate] ([parâmetros])

Por que usar? 

Flexibilidade: passar métodos como parâmetros para outros métodos.
Desacoplamento: o código não precisa saber qual função será chamada, apenas que existe uma função compatível.
Eventos e callbacks: em C#, eventos são baseados em delegates.
Reuso: facilita criar algoritmos genéricos que podem executar diferentes lógicas dependendo do delegate fornecido.

*/

using System;

class Program
{
    // Definição de um delegate que representa métodos que recebem um int e retornam um int
    delegate int Operacao(int x);

    static void Main()
    {
        // associando os métodos criados a partir do delegate
        Operacao dobrar = Dobrar;
        Operacao triplicar = Triplicar;

        // Usando os delegates (chamando os métodos indiretamente)
        Console.WriteLine(dobrar(5));  
        Console.WriteLine(triplicar(5)); 

        // Delegate como parâmetro 
        ExecutarOperacao(7, dobrar);   
        ExecutarOperacao(7, triplicar);
    }

    static int Dobrar(int n) => n * 2;
    static int Triplicar(int n) => n * 3;

    // passando o delegate como parâmetro para outro método, que executa a lógica sem precisar saber qual função foi usada
    static void ExecutarOperacao(int valor, Operacao op)
    {
        int resultado = op(valor);
        Console.WriteLine($"Resultado = {resultado}");
    }
}