// Usar o modificador abstract na classe indica que ela destina-se apenas em ser uma classe base de outras classes, não podendo ser instanciada.

// Não pode ser combinado com virtual nem static

public abstract class Forma
{
    // propriedades
    public string Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    // métodos abstratos -> serão OBRIGATÓRIOS nas classes que herdarem Forma. Devem ser configurados em cada classe derivada. Aqui fica vazio mesmo.
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    // método comum
    public string Descricao()
    {
        return "Sou a classe abstrata Forma.";
    }
}

public class Quadrado : Forma
{
    public double Lado { get; set; }
    public override void CalcularArea()
    {
        this.Area = Lado * Lado;
    }
    public override void CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
    }
}

public class Program
{
    public static void Main()
    {
        // Forma formas = new Forma(); -> retorna erro, já que não podemos instanciar classes abstract

        Quadrado q = new(); // quem eu chamo é sempre a classe derivada, e nunca a classe abstract base
        Console.WriteLine(q.Descricao());

        Console.WriteLine("\nInforme a cor da figura: ");
        q.Cor = Console.ReadLine();

        Console.WriteLine("\nInforme o valor do lado do quadrado: ");
        q.Lado = Convert.ToInt32(Console.ReadLine());

        q.CalcularArea();
        q.CalcularPerimetro();

        Console.WriteLine($"\nÁrea do quadrado: {q.Area}m2"); ;
        Console.WriteLine($"\nPerímetro do quadrado: {q.Perimetro}m");
        Console.WriteLine($"\nCor do quadrado: {q.Cor}");

        Console.ReadKey();
    }
}