// Classe array fornece métodos para criar, manipular, pesquisar e classificar arrays

// Reverse - inverte a sequência de um array unidimensional -> array.Reverse(nome_array);

// Sort - ordena os itens de um array -> array.Sort(nome_array);

// BinarySearch - faz a busca em um array ordenado de um valor usando algoritmo de busca binário.

public class ManipulacoesNoArray
{
     public static void ExibeArray(string[] nomes)
    {
        foreach (var nome in nomes)
        {
            Console.Write($"|{nome}|");
        }
    }
}

public class Program
{
    static void Main()
    {
        string[] nomes = { "Fernando", "Ana", "Bruno", "Carlos", "Wilson", "José" };

        Console.WriteLine("Array original: ");
        ManipulacoesNoArray.ExibeArray(nomes);

        Console.WriteLine("\n\nArray invertido: ");
        Array.Reverse(nomes);
        ManipulacoesNoArray.ExibeArray(nomes);

        Console.WriteLine("\n\nArray ordenado: ");
        Array.Sort(nomes);
        ManipulacoesNoArray.ExibeArray(nomes);

        Console.WriteLine("\n\nLocalizando um item no array:");
        Console.WriteLine("Informe o nome:");
        string? nome = Console.ReadLine();
        var indice = Array.BinarySearch(nomes, nome);
        if (indice >= 0)
        {
            Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}.");
        }
        else
        {
            Console.WriteLine($"Não encontramos o valor -> {nome}");
        }
    }
}