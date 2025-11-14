/*
 
É uma coleção genérica não ordenada que implementa a interface HashSet<T> e representa um conjunto de itens exclusivos (não permite inclusão de elementos duplicados).

Se a ordem não for um fator, essa coleção é ideal por ser mais rápida na busca, visto que não existem elementos iguais.

Claro! Aqui está uma lista objetiva com os principais métodos da classe `HashSet<T>` em C#:

### 🔧 Métodos principais do `HashSet<T>`

| Método                      | Descrição rápida                                       |
|----------------------------|--------------------------------------------------------|
| `Add(item)`                | Adiciona um item se ainda não existir                  |
| `Remove(item)`             | Remove um item específico                              |
| `Clear()`                  | Remove todos os itens                                  |
| `Contains(item)`           | Verifica se o item existe                              |
| `Count`                    | Retorna o número de elementos                          |
| `UnionWith(collection)`    | Une com outra coleção (sem duplicatas)                 |
| `IntersectWith(collection)`| Mantém apenas os itens comuns                          |
| `ExceptWith(collection)`   | Remove os itens que existem na outra coleção           |
| `SymmetricExceptWith(coll)`| Mantém apenas os itens exclusivos de cada coleção      |
| `IsSubsetOf(collection)`   | Verifica se é subconjunto                              |
| `IsSupersetOf(collection)` | Verifica se é superconjunto                            |
| `Overlaps(collection)`     | Verifica se há interseção                              |
| `SetEquals(collection)`    | Verifica se os conjuntos são iguais                    |
| `CopyTo(array)`            | Copia os elementos para um array                       |
| `TrimExcess()`             | Reduz a capacidade para o número real de elementos     |

*/

// criando com itens
var numeros = new HashSet<int> { 1, 2, 6, 7, 1 };

// 

var timesSP = new HashSet<string> { "Corinthians", "São Paulo", "Palmeiras"};
var timesRJ = new HashSet<string> { "Flamengo", "Vasco", "Fluminense" };
var timesMundiais = new HashSet<string>() { "Corinthians", "Santos", "Flamengo", "São Paulo"};