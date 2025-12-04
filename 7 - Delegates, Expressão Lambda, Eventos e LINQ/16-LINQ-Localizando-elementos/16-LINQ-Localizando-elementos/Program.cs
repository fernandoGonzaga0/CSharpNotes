/*

Principais métodos para busca em LINQ:

First -> retorna o primeiro elemento da sequência ou o elemento que atenda a uma condição e lança uma exceção se nenhum elemento for encontrado.

FirstOrDefault -> retorna o primeiro elemento da sequência ou o elemento que atenda uma condição. Retorna o valor padrão se nenhum elemento for encontrado.
 
*/

using _16_LINQ_Localizando_elementos;

// obtendo a lista da classe produto pelo método GetProdutos
var listaProdutos = Produto.GetProdutos();

// localizando o primeiro produto
Console.WriteLine("\n-First - Localiza o primeiro elemento: ");
var primeiroProduto = listaProdutos.First();
Console.WriteLine($"\nProduto: {primeiroProduto.Nome}, valor: {primeiroProduto.Preco}\n");

// localizando a primeira ocorrência
Console.WriteLine("\n-First - Localiza a primeira ocorrência: ");
var primeiraOcorrencia1 = listaProdutos.First(p => p.Nome == "Notebook UltraBook 14\"");
Console.WriteLine($"\nProduto: {primeiraOcorrencia1.Nome}, valor: {primeiraOcorrencia1.Preco}\n");