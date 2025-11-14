/*

Uma interface é um contrato que define um conjunto de métodos, propriedades, eventos ou indexadores que uma classe deve implementar.

Ela NÃO contém implementação, apenas a assinatura dos membros. 
 
Características: 

i) Não possui corpo (os métodos são apenas declarados, sem lógica).
ii) Não pode conter campos (variáveis).
iii) pode conter propriedades, métodos, eventos e indexadores.
iv) Suporta herança múltipla: uma classe pode implementar várias interfaces.
v) Promove o desacoplamento entre componentes.
 
 */

// interface
public interface IVeiculo
{
    void Acelerar();
    void Frear();
}

// implementando a interface em uma classe 
public class Carro : IVeiculo // é possível herdar mais de uma interface
{
    public void Acelerar()
    {
        Console.WriteLine("Carro acelerando...");
    }

    public void Frear()
    {
        Console.WriteLine("Carro freando...");
    }
}

public class Program
{
    static void Main()
    {
        /*
        É possível chamar a classe da forma padrão:

        Carro carro1 = new();
        carro1.Acelerar();
        carro1.Frear();         
         
        Vamos optar por referenciar a classe a partir da interface:
         */
        IVeiculo carro1 = new Carro();
        carro1.Acelerar();
        carro1.Frear();
    }
}