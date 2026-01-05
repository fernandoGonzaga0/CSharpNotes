/*

DownCasting é quando você pega um objeto que está referenciado como classe base e o converte para classe derivada.

Precisa ser feito explicitamente (com () ou usando as).

É útil quando você precisa acessar métodos ou propriedades específicas de classes derivadas que não existem na classe base.
 
*/

class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz algum som.");
    }
}

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

class Gato: Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato está miando.");
    }
    public void Escalar()
    {
        Console.WriteLine("O gato está escalando.");
    }
}

class Program
{
    static void Main()
    {
        // lista genérica de animais (graças ao upcasting)
        List<Animal> animais = new List<Animal>
        {
            new Cachorro(),
            new Gato()
        };

        // iterando a lista chamando FazerSom, cada objeto responde de acordo com sua classe derivada
        // para acessar métodos específicos (Correr ou Escalar) precisamos fazer o downcasting.
        foreach(Animal a in animais)
        {
            a.FazerSom(); // polimorfismo em ação

            // downcasting: verificar o tipo real antes de converter 
            if (a is Cachorro)
            {
                Cachorro dog = (Cachorro)a; // conversão explícita
                dog.Correr(); // método específico de cachorro
            }
            else if (a is Gato)
            {
                Gato cat = a as Gato; // conversão usando 'as'
                cat.Escalar(); // método específico de gato
            }
        }
    }
}