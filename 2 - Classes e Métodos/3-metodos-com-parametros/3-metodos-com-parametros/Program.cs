// Exemplo de método com parâmetros

public class PrimeiraClasse
{
    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PrimeiraClasse objeto1 = new PrimeiraClasse(); // importando a classe e criando uma instância dela (basicamente, criando um objeto)

        // nesse momento vamos chamar o método Saudacao com dois parâmetros
        objeto1.Saudacao("Fernando Gonzaga", "23/10/2025"); // essas duas strings são argumentos utilizados para preencher os dois parâmetros estabelecidos em Saudacao
    }
}