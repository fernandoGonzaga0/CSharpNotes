/*

EventHandler é um método que vai manipular um evento que NÃO POSSUI DADOS.

EventHandler sintaxe -> void Metodo(object? sender, EventArgs e)

Ele recebe dois parâmetros: sender (o objeto que disparou o evento); e (os dados do evento)

Analogia: Imagine que você está em uma sala com um botão. Quando você aperta o botão: O botão diz: “Ei, alguém apertou!”. Ele também diz quem apertou (sender) e o que aconteceu (e).
Isso é exatamente o que o EventHandler faz: ele notifica e informa detalhes.

*/

using System;

class Pedido
{
    // evento usando EventHandler
    public event EventHandler? PedidoCriado;

    public void Criar()
    {
        Console.WriteLine("Pedido criado.");
        PedidoCriado?.Invoke(this, EventArgs.Empty); // disparando o evento .this (o objeto Pedido que disparou) e EventArgs.Empty (nenhum dado extra, só o aviso)
    }
}

class Notificador
{
    public void AoCriarPedido(object? sender, EventArgs e)  // método que será chamado quando o evento for disparado (deve ter a mesma assinatura do delegate EventHandler
    {
        Console.WriteLine("Notificador: Recebi o aviso de que um pedido foi criado.");
    }
}

class Program
{
    static void Main()
    {
        var pedido = new Pedido();
        var notificador = new Notificador();

        // inscreve o método no evento
        pedido.PedidoCriado += notificador.AoCriarPedido;

        pedido.Criar();
    }
}