using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira o primeiro valor");
        double valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Números inseridos: {valor1} e {valor2}\n" +
            $"Soma -> {valor1} + {valor2} = {valor1+valor2}\n" +
            $"Subtração -> {valor1} - {valor2} = {valor1 - valor2}\n" +
            $"Multiplicação -> {valor1} * {valor2} = {valor1 * valor2}\n" +
            $"Divisão -> {valor1} / {valor2} = {valor1 / valor2}\n" +
            $"Exponenciação -> {valor1} ^ {valor2} = {Math.Pow(valor1, valor2)}\n" +
            $"Módulo -> {valor1} % {valor2} = {valor1 % valor2}\n");
    }
}