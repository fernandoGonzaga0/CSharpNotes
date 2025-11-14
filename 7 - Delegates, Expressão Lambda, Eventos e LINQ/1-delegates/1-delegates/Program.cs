/*
 
Um delegate é um tipo (como int, double, string, etc.) que representa referências a métodos com uma lista de parâmetros e um tipo de retorno específicos. Ao instanciar um delegate, podemos associar a sua instância a qualquer método com uma assinatura compatível e tipo de retorno, e, podemos invocar o método por meio da instância delegada. Os delgates são usados para implementar eventos, métodos de retorno de chamada e para passar métodos como argumentos para outros métodos.

Há 3 etapas envolvidas ao trabalhar com delegates:

1) Declarar um delegate;
2) Definir um método de destino;
3) Invocar/chamar o delegate.

Sintaxe -> [modificador de acesso] delegate [tipo de retorno] [nome do delegate] ([parâmetros])
 
*/

// método de destino
static void MeuMetodo(string msg)
{
    Console.WriteLine(msg);
}

// 1) Primeira forma de definição do método destino
MeuDelegate del1 = new MeuDelegate(MeuMetodo);

// 2) Segunda forma de definição do método destino
MeuDelegate del2 = MeuMetodo;

// 3) Terceira forma (expressão lambda)
MeuDelegate del3 = (msg) => Console.WriteLine(msg);

//Declaração do delegate
public delegate void MeuDelegate(string mensagem);