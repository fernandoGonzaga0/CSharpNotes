/*
 
Dictionary<TKey,TValue> é uma classe que representa uma coleção do tipo chave/valor e implementa a interface IDictionary que possui duas coleções no seu interior, uma para guardar a chave e outra para guardar o valor. 
 
 Principais propriedades:

    Count - Obtém o número total de elementos no Dictionary<Tkey,TValue>
    IsReadOnly - Retorna um booleano indicando se o Dictionary é somente leitura ou não.
    Item - Obtém ou define o elemento com a chave especificada no Dictionary 
    Keys - Retorna a coleção de chaves no Dictionary 
    Values - Retorna a coleção de valores no Dictionary
    Comparer - Obtém o IEqualityComparer<T> que é usado para determinar a igualdade de chaves para o dicionário

Principais métodos:

    Add - Adiciona a chave e o valor ao Dictionary. Lança uma exceção ArgumentException se a chave já existir.
    TryAdd - Tenta adicionar um elemento com chave e valor definidos e retorna true ou false.
    Clear - Remove todas as chaves e valores do Dictionary.
    ContainsKey - Determina se o Dictionary atual contém a chave especificada
    ContainsValue - Determina se o Dicionary atual contém o valor especificado
    Remove - Remove o valor com a chave especificada
    TryGetValue - Obtém o valor associado à chave especificada. Se não existir retorna o valor padrão para o tipo do parâmetro TValue.
 
*/

// Dicionário de números pares, com chave crescente e valor contendo os pares

Dictionary<int, int> dicionario1 = new Dictionary<int, int>(); // criando um dicionario com chave,valor
dicionario1.Add(0, 0);
dicionario1.Add(1, 2);
dicionario1.Add(2, 4);
dicionario1.Add(3, 6);
dicionario1.Add(4, 8);

// usando TryAdd para tentar adicionar uma chave e valor no dicionário. Vamos atribuir na variável tentativa e receber true se der certo ou false se a chave já existir.
var TentativaAddChave = dicionario1.TryAdd(1, 12); // false
Console.WriteLine($"Foi possível inserir o valor no dicionário? {TentativaAddChave}");

// percorrendo o dicionário e exibindo todos os valores
foreach (var item in dicionario1)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}