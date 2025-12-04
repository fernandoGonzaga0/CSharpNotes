using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_biblioteca;

internal class Livro
{
    public static int Id;
    public static string? Titulo { get; set; }
    public static string? Autor {  get; set; }
    public static int AnoPublicacao { get; set; }
    
    // construtor para receber os 4 argumentos
    public Livro(int id, string? titulo, string? autor, int anoPublicacao)
    {
        Id = id;
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }
}