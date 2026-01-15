using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LINQ_Agrupamento;

public class Produto
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string? Categoria { get; set; }

    public static List<Produto> GetProdutos()
    {
        List<Produto> produtos = new List<Produto>();
        {
            produtos.Add(new Produto { Id = 1, Nome = "Camiseta", Preco = 29.99, Estoque = 89, Categoria = "Vestuário" });
            produtos.Add(new Produto { Id = 2, Nome = "Arroz Integral 1kg", Preco = 7.49, Estoque = 120, Categoria = "Alimentos" });
            produtos.Add(new Produto { Id = 3, Nome = "Smartphone XZ10", Preco = 1899.90, Estoque = 35, Categoria = "Eletrônicos" });
            produtos.Add(new Produto { Id = 4, Nome = "Sabonete Lavanda", Preco = 3.25, Estoque = 200, Categoria = "Higiene Pessoal" });
            produtos.Add(new Produto { Id = 5, Nome = "Cadeira de Escritório", Preco = 349.99, Estoque = 15, Categoria = "Móveis" });
            produtos.Add(new Produto { Id = 6, Nome = "Tênis Esportivo", Preco = 159.90, Estoque = 42, Categoria = "Calçados" });
            produtos.Add(new Produto { Id = 7, Nome = "Notebook UltraBook 14\"", Preco = 3299.00, Estoque = 20, Categoria = "Eletrônicos" });
            produtos.Add(new Produto { Id = 8, Nome = "Shampoo Anticaspa", Preco = 18.75, Estoque = 85, Categoria = "Cosméticos" });
            produtos.Add(new Produto { Id = 9, Nome = "Biscoito Recheado", Preco = 2.99, Estoque = 150, Categoria = "Alimentos" });
            produtos.Add(new Produto { Id = 10, Nome = "Liquidificador Turbo", Preco = 129.90, Estoque = 30, Categoria = "Eletrônicos" });
            produtos.Add(new Produto { Id = 11, Nome = "Blusa de Frio", Preco = 89.90, Estoque = 60, Categoria = "Vestuário" });
            produtos.Add(new Produto { Id = 12, Nome = "Caderno Universitário", Preco = 14.50, Estoque = 100, Categoria = "Papelaria" });
            produtos.Add(new Produto { Id = 13, Nome = "Lâmpada LED 9W", Preco = 8.99, Estoque = 75, Categoria = "Eletrônicos" });
            produtos.Add(new Produto { Id = 14, Nome = "Detergente Neutro", Preco = 2.45, Estoque = 180, Categoria = "Limpeza" });
            produtos.Add(new Produto { Id = 15, Nome = "Brinquedo Educativo", Preco = 49.90, Estoque = 40, Categoria = "Infantil" });
        }
        ;
        return produtos;
    }
}