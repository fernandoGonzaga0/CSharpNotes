using _16_gerenciador_produtos;
using System;

public class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>(); // criando e iniciando a lista

        Console.WriteLine("----- Gerenciador de Produtos -----\n");

        produtos.Add(new Produto(1, "Notebook Positivo", "Informática", 3500, 5));
        produtos.Add(new Produto(2, "Geladeira Eletrolux", "Eletrodoméstico", 4799, 12));
        produtos.Add(new Produto(3, "Fogão Eletrolux", "Eletrodoméstico", 1299, 6));
        produtos.Add(new Produto(4, "Armário de madeira", "Móveis", 579, 7));
        produtos.Add(new Produto(5, "Chuveiro", "Eletrodoméstico", 325, 10));
        produtos.Add(new Produto(6, "Grade de janela", "Metais", 129, 4));

        Console.WriteLine("Listando produtos:\n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"\tId: {produto.Id}, Produto: {produto.Nome}, Categoria: {produto.Categoria}, Preço: {produto.Preco}, Estoque: {produto.Estoque}");
        }

        // Exibindo produtos acima de R$1.000,00
        Console.WriteLine("\nProdutos acima de R$1.000,00:");
        var produtosAcimaCem = produtos.Where(n => n.Preco >=1000);
        foreach (var prod in  produtosAcimaCem)
        {
            Console.WriteLine($"\tProduto: {prod.Nome}, Preço {prod.Preco}");
        }

        // Exibindo produtos da categoria Eletrodoméstico
        Console.WriteLine("\nProdutos da categoria ELETRODOMÉSTICOS:");
        var eletrodomesticos = produtos.Where(n => n.Categoria == "Eletrodoméstico");
        foreach (var eletro in eletrodomesticos)
        {
            Console.WriteLine($"\tProduto: {eletro.Nome}, Categoria: {eletro.Categoria}");
        }

        // Exibindo os produtos com estoque baixo (menos de 7 unidades)
        Console.WriteLine("\nProdutos com estoque baixo (menos de 7)");
        var estoqueBaixo = produtos.Where(n => n.Estoque < 7);
        foreach (var estqBaixo in estoqueBaixo)
        {
            Console.WriteLine($"\tProduto: {estqBaixo.Nome}, Estoque: {estqBaixo.Estoque}");
        }

    }
}