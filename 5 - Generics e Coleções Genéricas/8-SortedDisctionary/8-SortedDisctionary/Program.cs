/*
 
É uma coleção genérica que armazena dados no formato chave/valor de forma ordenada onde a ordenação é feita pela chave.

As chaves da coleção SortedDictionary devem ser exclusivas e não nulas e manter a ordem crescente sendo usadas para realizar pesquisas e remover elementos da coleção.

As propriedades e métodos são praticamente idênticos aos de Dictionary

*/

var brics = new SortedDictionary<int, string>();
brics.Add(2, "Brasil");
brics.Add(3, "Índia");
brics.Add(1, "China");
brics.Add(0, "URSS");

foreach (var pais in brics)
{
    Console.WriteLine(pais);
}

// forma correta de add na lista sorted
if (brics.ContainsKey(7))
{
    Console.WriteLine("Chave já existente!");
}
else
{
    brics.Add(7, "Africa do Sul");
}

Console.WriteLine();

foreach (var pais in brics)
{
    Console.WriteLine(pais);
}