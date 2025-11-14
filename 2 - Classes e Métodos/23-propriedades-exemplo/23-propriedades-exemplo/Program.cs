public class Produto
{
    // 1)
    private string? nome; // componente nome privado
    public string? Nome // propriedade Nome pública
    { 
        get { return nome.ToUpper();  } // quando inserirem o valor em Nome, get formatará para caixa alta
        
        set { nome = value; } 
    }

    // 2)
    public double Preco { get; set; }

    // 3)
    private double desconto = 0.05; // propriedade será apenas para leitura, visto que o desconto está fixo em 5% (não será possível atribuir valor para desconto no Main() )
    public double Desconto 
    { 
        get { return desconto; } // apenas get = somente leitura
    
    }

    // 4)
    public double PrecoFinal { get; set; }

    // 5)
    public int EstoqueMinimo { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto}" +
            $"\n{PrecoFinal.ToString("c")} \n{EstoqueMinimo}");
    }
}