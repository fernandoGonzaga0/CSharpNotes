// Consultas LINQ mais relevantes.

using _15_LINQ_consultas;

var listaProdutos = Produto.GetProdutos();

// 1) filtrando produtos por categoria
var produtoEletronico = listaProdutos.Where(p => p.Categoria == "Eletrônicos");
Console.WriteLine("----- 1) Exibindo produtos eletrônicos -----");
foreach (var produto in produtoEletronico)
{
    Console.WriteLine($"\nProduto: {produto.Nome}, preço {produto.Preco:C2}");
}

// 2) Filtrando com duas condições
Console.WriteLine("\n----- 2) Produtos mais caros com estoque superior a 5 -----");
var produtosCarosComEstoque = listaProdutos.Where(p => p.Preco >= 500 && p.Estoque > 5);
foreach (var produto in produtosCarosComEstoque)
{
    Console.WriteLine($"\n{produto.Nome} -> Preço: {produto.Preco:C2}, Estoque: {produto.Estoque}");
}

// 3) Filtrando com ordenação.
Console.WriteLine("\n----- 3) Lista de produtos com estoque mínimo (<10) ordenados por nome -----");
var produtoEstoqueMinimo = listaProdutos.Where(p => p.Estoque >= 10).OrderBy(p => p.Nome);
foreach (var produto in produtoEstoqueMinimo)
{
    Console.WriteLine($"\n{produto.Nome}, Estoque: {produto.Estoque}");
}

// 4) Ordenando por mais de um critério
Console.WriteLine("\n----- 4) Produtos ordenados por categoria e nome -----");
var produtosOrdenadosPorCategoriaENome = listaProdutos.OrderBy(p => p.Categoria).ThenBy(p => p.Nome);
string? categoriaAnterior = "";
foreach (var produto in produtoEstoqueMinimo)
{
    if (produto.Categoria != categoriaAnterior)
    {
        Console.WriteLine($"    {produto.Categoria}");
        categoriaAnterior = produto.Categoria;
    }
    Console.WriteLine($"        {produto.Nome}");
}