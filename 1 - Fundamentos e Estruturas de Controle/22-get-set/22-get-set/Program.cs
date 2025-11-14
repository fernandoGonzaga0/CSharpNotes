// Get e Set são acessores de propriedades - uma forma de controlar o acesso (leitura e escrita) nas variáveis de uma classe.

// Exemplo de campo público e exposto
public class Pessoa1
{
    public string Nome; // qualquer código pode alterar isso livremente
}

// Exemplo mais seguro com Get e Set

public class Pessoa2
{
    private string nome; // campo privado
    public string Nome
    {
        get { return nome; }  // leitura -> retorna o valor do campo
        set { nome = value; } // escrita -> define o valor do campo
    }
}

class Program
{
    static void Main()
    {
        Pessoa2 p1 = new();
        p1.Nome = "Maria";             // chama o set { nome = value }
        Console.WriteLine(p1.Nome);    // chama o get { return nome; }
    }
}