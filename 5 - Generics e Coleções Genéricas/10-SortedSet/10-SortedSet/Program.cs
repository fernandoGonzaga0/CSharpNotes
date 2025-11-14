/*

SorteSet é uma coleção genérica ordenada que representa um conjunto de itens exclusivos (não permite a inclusão de elementos duplicados).

### 🔤 Métodos do `SortedSet<T>` em ordem alfabética

| Método                        | Descrição rápida                                           |
|------------------------------|------------------------------------------------------------|
| `Add(item)`                  | Adiciona um item mantendo a ordenação                     |
| `Clear()`                    | Remove todos os itens                                     |
| `Contains(item)`             | Verifica se o item existe                                 |
| `CopyTo(array)`              | Copia os elementos para um array                          |
| `ExceptWith(collection)`     | Remove os itens que existem na outra coleção              |
| `GetViewBetween(min, max)`   | Retorna uma subcoleção entre dois valores                 |
| `IntersectWith(collection)`  | Mantém apenas os itens comuns                             |
| `IsProperSubsetOf(collection)` | Verifica se é subconjunto próprio                        |
| `IsProperSupersetOf(collection)` | Verifica se é superconjunto próprio                   |
| `IsSubsetOf(collection)`     | Verifica se é subconjunto                                 |
| `IsSupersetOf(collection)`   | Verifica se é superconjunto                               |
| `Max`                        | Retorna o maior elemento                                  |
| `Min`                        | Retorna o menor elemento                                  |
| `Overlaps(collection)`       | Verifica se há interseção                                 |
| `Remove(item)`               | Remove um item específico                                 |
| `Reverse()`                  | Retorna um enumerador em ordem decrescente                |
| `SetEquals(collection)`      | Verifica se os conjuntos são iguais                       |
| `SymmetricExceptWith(coll)`  | Mantém apenas os itens exclusivos de cada coleção         |
| `TryGetValue(item, out val)` | Tenta obter o valor equivalente ao item                   |
| `UnionWith(collection)`      | Une com outra coleção (sem duplicatas)                    |

Se quiser, posso fazer o mesmo com `HashSet<T>` ou mostrar exemplos práticos de uso desses métodos.
*/