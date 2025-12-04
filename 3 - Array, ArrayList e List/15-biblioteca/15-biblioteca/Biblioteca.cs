using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_biblioteca;

public class Biblioteca
{
    List<Livro> livros = new List<Livro>(); // livros passa a ser minha lista
    int indiceLivro;
    int id; // int para Id do livro

    public void AdicionarLivro()
    {
        int Id = id + 1;

        Console.WriteLine("\n--- Adicionando livro ---\nTítulo do livro:\n");
        string? titulo = Console.ReadLine();

        Console.WriteLine("\nNome do autor:\n");
        string? autor = Console.ReadLine();

        Console.WriteLine("\nAno de publicação:\n");
        int anoPublicacao = Convert.ToInt32(Console.ReadLine());

        Livro novoLivro = new Livro(Id, titulo, autor, anoPublicacao);

        livros.Add(novoLivro);

        Console.WriteLine("\nLivro adicionado!");
    }

    public void RemoverLivro()
    {
        Console.WriteLine("\nInsira o índice do livro para exclusão:");
        indiceLivro = Convert.ToInt32(Console.ReadLine());
        livros.RemoveAt(indiceLivro);
    }

}