/*

Tipos de relacionamentos entre classes -> 

                                            i  - é um (herança);
                                            ii - tem um (composição e agregação);

Representa uma associação onde o objeto composto NÃO EXISTE sem o objeto principal (relação forte).

Ex: a classe Carro contém referências às classes Motor e Pneu. Com isso, podemos escolher quais métodos/propriedades serão enviadas à classe composta, 
ao invés de herdar todas as funcionalidades das classes. Porém, as classes Motor e Pneu dependem diretamente da classe Carro. Se a casa fosse destruída, 
elas também seriam.

 */

public class Motor
{
    public void Ligar() => Console.WriteLine("Motor ligado!");
}

public class Pneu
{
    public void Aquecendo() => Console.WriteLine("Pneus aquecendo...");
}

public class Carro
{
    private Motor motor = new Motor(); // criado dentro do carro
    private Pneu pneu = new Pneu(); // criado dentro do carro

    public void LigarCarro()
    {
        motor.Ligar();
        pneu.Aquecendo();
        Console.WriteLine("Motor ligado e pneus aquecendo.");
    }
}

public class Program
{
    static void Main()
    {
        Carro carro1 = new();
        carro1.LigarCarro();
    }
}