/*

EventHandler<TEventArgs> é uma variação genérica do delegate EventHandler, usada quando você quer enviar dados personalizados junto com o evento. 

Assinatura padrão -> void Metodo(object? sender, TEventArgs e)  |  sender = quem disparou o evento,  e = uma instância de uma classe que herda de EventArgs, com os dados do evento.

Por que usar? Imagine que você quer notificar que um pedido foi criado, mas também quer informar o número do pedido e o nome do cliente. O EventHandler<T> permite isso de forma organizada e segura.
 
*/

// classe de argumentos
public class PedidoEventArgs : EventArgs
{
    public int NumeroPedido { get; }
    public string? Cliente { get; }
    public PedidoEventArgs(int numeroPedido, string? cliente)
    {
        NumeroPedido = numeroPedido;
        Cliente = cliente;
    }
}

// criando evento com EventHandler<T>
public class Pedido
{
    public event EventHandler<PedidoEventArgs>? PedidoCriado;
    public void Criar(int numero, string? cliente)
    {
        Console.WriteLine("Pedido criado!");
        PedidoCriado?.Invoke(this, new PedidoEventArgs(numero, cliente));
    }
}

// criando o assinante
public class Notificador
{
    public void AoCriarPedido(object sender, PedidoEventArgs e)
    {
        Console.WriteLine($"Notificador: Pedido #{e.NumeroPedido} criado para {e.Cliente}.");
    }
}

// usando tudo junto
class Program
{
    static void Main()
    {
        var pedido = new Pedido();
        var notificador = new Notificador();

        pedido.PedidoCriado += notificador.AoCriarPedido;

        pedido.Criar(123, "Fernando");
    }
}