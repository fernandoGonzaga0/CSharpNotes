/*

Eventos são mecanismos que permitem que uma classe ou objeto notifique outras classes ou objetos quando alguma ação ocorre.

A classe que envia (ou aciona) o evento é chamada de Publisher ou Publicador e as classes que recebem (ou manipulam) os eventos são chamadas de Subscribers ou Assinantes.

Um evento usa um delegate como tipo base, mas só pode ser acionado de dentro da classe que o declara — isso evita que código externo dispare o evento acidentalmente.

*/
delegate void PedidoEventHandler(); // esse delegate define a assinatura dos métodos que podem ser chamados quando o evento ocorre (no caso, qualquer um que esteja vazio)
class Pedido
{

    public event PedidoEventHandler? OnCriarPedido; // esse é o evento que será disparado quando o pedido for criado. Ele é baseado no delegate PedidoEventHandler()
                                                    // só pode ser disparado de dentro da classe Pedido.
    public void CriarPedido()
    {
        Console.WriteLine("Pedido criado!");
        if (OnCriarPedido != null)
        {
            OnCriarPedido();   // aqui acontece o disparo do evento. Todos os métodos que forem inscritos via += serão chamados.
        }
    }
}

class Email
{
    public static void Enviar() // método Enviar 
    {
        Console.WriteLine("Enviando um email.");
    }
}

class SMS
{
    public static void Enviar() // método Enviar
    {
        Console.WriteLine("Enviando um SMS.");
    }
}

class Program
{
    // criando um delegate para o tipo de evento que quero acionar
    static void Main()
    {
        var pedido = new Pedido();

        // inscrevendo os assinantes no evento | basicamente: quando o evento OnCriarPedido for disparado, execute também os métodos Email.Enviar e SMS.Enviar.
        pedido.OnCriarPedido += Email.Enviar;
        pedido.OnCriarPedido += SMS.Enviar;

        pedido.CriarPedido();
    }
}

