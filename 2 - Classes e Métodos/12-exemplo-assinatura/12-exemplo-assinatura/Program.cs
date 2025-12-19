Console.WriteLine("----- Métodos -----");

Cliente cliente = new Cliente();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    public Cliente() { } // construtor permitindo a inicialização do objeto vazia
}

public class Cadastro
{
    // criando um método que tem como tipo um objeto da classe Cliente, logo, temos que retornar esse tipo também
    public Cliente Registrar()
    {
        Cliente cliente = new("Maria", 25, 4280);
        return cliente;
    }
}