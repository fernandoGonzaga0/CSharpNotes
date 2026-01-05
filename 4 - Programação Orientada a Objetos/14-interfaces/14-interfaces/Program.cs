/*

Uma interface é um contrato que define um conjunto de métodos, propriedades, eventos ou indexadores que uma classe deve implementar.
 
Características: 

i) Não pode conter campos (variáveis).
ii) pode conter propriedades, métodos, eventos e indexadores.
iii) Suporta herança múltipla: uma classe pode implementar várias interfaces.
iv) Promove o desacoplamento entre componentes.

 */

public interface IVeiculo
{
    void Acelerar();
    void Frear();

    // Método com implementação padrão
    void Exibir()
    {
        Console.WriteLine("Veículo padrão exibido.");
    }
}

public class Carro : IVeiculo
{
    public void Acelerar() => Console.WriteLine("Carro acelerando...");
    public void Frear() => Console.WriteLine("Carro freando...");
    // Não precisa implementar Exibir(), pois já existe uma versão padrão
}

public class Program
{
    public static void Main()
    {
        IVeiculo carro = new Carro();
        carro.Exibir(); // chama a implementação padrão da interface
    }
}