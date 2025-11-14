using System;
using System.Linq; // para utilização do método Max()

class Program
{
    public static void Main()
    {
        Console.WriteLine("----- MAIOR NÚMERO -----\n");
        Console.WriteLine("Insira o primeiro número: ");
        double FirstNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira o segundo número: \n");
        double SecondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nInsira o terceiro número: \n");
        double ThirdNumber = Convert.ToDouble(Console.ReadLine());

        double maxNumber = Math.Max(Math.Max(FirstNumber, SecondNumber), ThirdNumber);

        Console.WriteLine($"Valores inseridos:\n" +
            $"Primeiro número: {FirstNumber}\n" +
            $"Segundo número: {SecondNumber}\n" +
            $"Terceiro número: {ThirdNumber}\n" +
            $"\aMaior número: {maxNumber}\n" +
            $"Encerrando...");

        Console.ReadKey();
    }
}
