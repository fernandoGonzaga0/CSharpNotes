/*
UpCasting é quando você trata um objeto de uma classe derivada como se fosse da classe base. 
Isso acontece automaticamente, sem precisar de conversão explícita.
O objetivo é GENERALIZAR o tratamento dos objetos, permitindo usar polimorfismo.
*/

// classe base
public class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal está fazendo algum som.");
    }
}

// classe derivada
class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
    public void Correr()
    {
        Console.WriteLine("O cachorro está correndo.");
    }
}

// classe derivada
class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia.");
    }
    public void Escalar()
    {
        Console.WriteLine("O gato está escalando.");
    }
}

public class Program
{
    static void Main()
    {
        // criando objetos das classes derivadas
        Cachorro dog = new Cachorro();
        Gato cat = new Gato();

        // upcasting: cachorro e gato tratados como Animal
        Animal animal1 = dog; // upcasting automático, onde o objeto animal1 continua sendo um cachorro, mas pode ser tratado como propriamente da classe Animal
        Animal animal2 = cat; // upcasting automático, onde o objeto animal2 continua sendo um gato, mas pode ser tratado como propriamente da classe Animal

        // chamando métodos da classe base (polimorfismo em ação)
        animal1.FazerSom();
        animal2.FazerSom();

        // como agora diferentes objetos de classe base iguais são tratados como únicos da classe base, podemos criar uma lista contendo esses objetos juntos
        List<Animal> animais = new List<Animal> { dog, cat };

        Console.WriteLine("\nLista de animais:");
        foreach (Animal a in animais)
        {
            a.FazerSom(); // cada objeto executa sua versão do método
        }
    }
}