/*

AS) 

O operador 'as' é usado para driblar o lançamento de exceções genéricas, gerando apenas um null (que não trava o programa).

Esse operador retorna o objeto quando ele é compatível com o tipo de dado e retorna null se a conversão não for possível ao invés de gerar uma exceção.

Ao realizar uma operação de downcasting (base -> derivada) ele avalia o resultado para null ao invés de lançar uma exceção (Invalid CastException).

O operador 'as' é um operador de conversão de tipos (referência e anuláveis).

*/

// classe base
class Veiculo
{
    public virtual void Mover()
    {
        Console.WriteLine("O veículo está se movendo.");
    }
}

// classe derivada
class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está dirigindo na estrada.");
    }
    public void LigarRadio()
    {
        Console.WriteLine("Ligando rádio...");
    }
}

// classe derivada
class Bicicleta : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("A bicicleta está pedalando.");
    }
    public void Empinar()
    {
        Console.WriteLine("Empinando bicicleta.");
    }
}

class Program
{
    static void Main()
    {
        // lista genérica (por causa do UpCasting feito )
        List<Veiculo> veiculos = new List<Veiculo>
        {
            new Carro(),
            new Bicicleta(),
            new Veiculo()
        };

        foreach (Veiculo v in veiculos)
        {
            v.Mover(); // polimorfismo, pois cada classe derivada possui uma variação do método

            // downcasting usando 'as' para tentar converter os veículos como a classe base (se não der certo, retorna null ao invés de uma exception)
            Carro c = v as Carro;
            if (c != null)
            {
                c.LigarRadio(); // método exclusivo de Carro
            }

            Bicicleta b = v as Bicicleta;
            if (b != null)
            {
                b.Empinar(); // método exclusivo de Bicicleta
            }
        }
    }
}