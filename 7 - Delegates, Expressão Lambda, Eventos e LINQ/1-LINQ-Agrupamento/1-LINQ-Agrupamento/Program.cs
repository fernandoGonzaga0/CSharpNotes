/*

GroupBy -> agrupa os elementos de uma sequência.

1) O agrupamento é dado por um objeto IGrouping<Tkey, T>
2) O Tkey representa a chave do agrupamento e T é o elemento que desejamos agrupar
3) Para uma chave composta, definimos um tipo anônimo usando a palavra-chave new
4) Retorna um IEnumerable<IGrouping<TKey, TSource>>
 
*/

using _1_LINQ_Agrupamento;

var listaProdutos = Produto.GetProdutos();

// agrupando produtos por categoria
var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria);
foreach(var grupo in produtosPorCategoria)
{
    Console.WriteLine(grupo.Key + " : " + grupo.Count());

    foreach(var produto in grupo)
    {
        Console.WriteLine($"    {produto.Nome} \t{produto.Preco} \t{produto.Estoque}");
    }
    Console.WriteLine();
}