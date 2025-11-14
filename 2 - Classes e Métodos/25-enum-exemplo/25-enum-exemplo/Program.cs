/*
 
Ex de menu de seleção com enum. 

Para obter o nome  -> Categoria.membro
Para obter o valor -> (tipo)Categoria.membro
 
*/

enum Categoria
{
    Moda,        //0
    Automotivo,  //1
    Artes,       //2
    Bebidas,     //3
    Livros,      //4
    Brinquedos   //5
}

class Program
{
    static void Main()
    {
        Console.WriteLine("----- MENU -----");

        Console.WriteLine($"{(int)Categoria.Moda} - {Categoria.Moda}\n" + // 0 - Moda
            $"{(int)Categoria.Automotivo} - {Categoria.Automotivo}\n" +
            $"{(int)Categoria.Artes} - {Categoria.Artes}\n" +
            $"{(int)Categoria.Bebidas} - {Categoria.Bebidas}\n" +
            $"{(int)Categoria.Livros} - {Categoria.Livros}\n" +
            $"{(int)Categoria.Brinquedos} - {Categoria.Brinquedos}\n");

        Console.WriteLine("Selecione a categoria teclando o seu valor: \n");

        int valor = Convert.ToInt32(Console.ReadLine());

        var nomeMembroEnum = (Categoria)valor;

        Console.WriteLine($"Categoria escolhida -> {nomeMembroEnum.ToString()}");
    }
}