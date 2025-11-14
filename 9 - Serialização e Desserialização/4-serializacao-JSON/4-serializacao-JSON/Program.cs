public class Produto
{
    public int Id;
    public string? Nome;
    public int Preco;
}

class Program
{
    public static void Main()
    {
        var produto = new Produto { Id = 1, Nome = "Mouse Gamer", Preco = 12 };

    }
}

