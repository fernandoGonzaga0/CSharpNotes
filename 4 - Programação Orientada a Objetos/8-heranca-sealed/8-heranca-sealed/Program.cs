/*
 
Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dla.

*/

 sealed class Pessoa
{
    public string? Nome { get; set; }

     public void ExibeNome()
    {
        Console.WriteLine($"Meu nome é {Nome}");
    }
}

class Cliente : Pessoa // como a classe Pessoa tem sealed em sua criação, não é possível herdá-la em derivadas
{
    public new void ExibeNome() 
    {
        //
    }
}