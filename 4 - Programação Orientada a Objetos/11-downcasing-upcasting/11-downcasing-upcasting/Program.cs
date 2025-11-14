/*
 
Upcasting é o processo de converter uma instância de uma classe derivada para uma referência da sua classe base. Isso é seguro e implícito em C#, 
pois toda classe derivada herda os membros públicos e protegidos da base.
 
*/

// Upcasting

using System;
using System.Collections.Generic;

class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void FazerSom()
    {
        Console.WriteLine($"{Nome} faz um som genérico.");
    }
}

class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Au au!");
    }
}

class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Miau!");
    }
}

class Program
{
    static void Main()
    {
        // Criando objetos das subclasses
        Animal a1 = new Cachorro("Rex");   // Upcasting implícito
        Animal a2 = new Gato("Mimi");      // Upcasting implícito

        // Lista de animais
        List<Animal> animais = new List<Animal> { a1, a2 };

        // Polimorfismo: cada animal faz seu som específico
        foreach (Animal a in animais)
        {
            a.FazerSom(); // Executa o método da subclasse, mesmo sendo tratado como Animal
        }
    }
}
