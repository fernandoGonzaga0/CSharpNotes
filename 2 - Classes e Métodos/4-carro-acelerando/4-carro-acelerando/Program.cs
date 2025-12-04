using System;

public class Carro
{
    public string? nome;
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public void Acelerar(string nome) // atribuindo nome para informar qual carro está acelerando
    {
        Console.WriteLine($"O carro {nome} está acelerando...\n");
    }

    public void ExibirDados (string nome, string modelo, string montadora, string marca, int ano, int potencia)
    {
        Console.WriteLine($"Especificações do carro:\n" +
                            $"Nome: {nome}\n" +
                            $"$\"Modelo: {modelo}\n" +
                            $"$\"Montadora: {montadora}\n" +
                            $"$\"Marca: {marca}\n" +
                            $"$\"Ano: {ano}\n" +
                            $"$\"Potência: {potencia}\n");

    }
}

class Program
{
    static void Main()
    {
        // objeto 1
        Carro chevrolet = new Carro();
        chevrolet.nome = "Chevrolet";
        chevrolet.modelo = "Sedan";
        chevrolet.montadora = "Chevrolet";
        chevrolet.marca = "Onix";
        chevrolet.ano = 2023;
        chevrolet.potencia = 400;

        chevrolet.ExibirDados(chevrolet.nome, chevrolet.modelo, chevrolet.montadora, chevrolet.marca, chevrolet.ano, chevrolet.potencia);
        chevrolet.Acelerar(chevrolet.nome);

        // objeto 2
        Carro ford = new Carro();
        ford.nome = "Ford";
        ford.modelo = "SUV";
        ford.montadora = "Ford";
        ford.marca = "EcoSport";
        ford.ano = 2018;
        ford.potencia = 120;

        ford.ExibirDados(ford.nome, ford.modelo, ford.montadora, ford.marca, ford.ano, ford.potencia);
        ford.Acelerar(ford.nome);
    }
}