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
        Console.WriteLine($"O carro {nome} está acelerando...");
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
        Console.WriteLine($"Especificações do carro:\n" +
            $"Nome: {chevrolet.nome}\n" +
            $"$\"Modelo: {chevrolet.modelo}\n" +
            $"$\"Montadora: {chevrolet.montadora}\n" +
            $"$\"Marca: {chevrolet.marca}\n" +
            $"$\"Ano: {chevrolet.ano}\n" +
            $"$\"Potência: {chevrolet.potencia}\n");

        chevrolet.Acelerar(chevrolet.nome);

        // objeto 2
        Carro ford = new Carro();
        ford.nome = "Ford";
        ford.modelo = "SUV";
        ford.montadora = "Ford";
        ford.marca = "EcoSport";
        ford.ano = 2018;
        ford.potencia = 120;
        Console.WriteLine($"\n\nEspecificaçÕes do carro:\n" +
            $"Nome: {ford.nome}\n" +
            $"$\"Modelo: {ford.modelo}\n" +
            $"$\"Montadora: {ford.montadora}\n" +
            $"$\"Marca: {ford.marca}\n" +
            $"$\"Ano: {ford.ano}\n" +
            $"$\"Potência: {ford.potencia}\n");

        ford.Acelerar(ford.nome);
    }
}