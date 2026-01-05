// Se você quiser que um membro da subclasse substitua um membro com o mesmo nome na classe base, deve fazer o seguinte:

// Use o modificador virtual na declaração do membro da classe base para permitir que ele sofra alterações partindo da classe derivada

class Animal // classe base
{
    public string? Nome {  get; set; }
    public virtual void ExibeNome()   // virtual está sinalizando que esse método pode ser sobrescrito em alguns cenários, onde haver override
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Gato : Animal
{
    public override void ExibeNome() // como contém override, o método ExibeNome será sobrescrito
    {
        Console.WriteLine($"Eu sou um gato. Meu nome é: {Nome}");
    }
}

class Cachorro : Animal
{
    // está herdando todas as informações de Animal, apenas
}

class Program
{
    public static void Main()
    {
        // gato
        Gato gato1 = new();
        gato1.Nome = "Frajola";
        gato1.ExibeNome();

        // cachorro 
        Cachorro cachorro1 = new();
        cachorro1.Nome = "Duck";
        cachorro1.ExibeNome();
    }
}