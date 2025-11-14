/*
 
Método PILHA -> Last in, First Out

### 🧱 Métodos do `Stack<T>` em ordem alfabética

| Método               | Descrição rápida                                      |
|---------------------|-------------------------------------------------------|
| `Clear()`           | Remove todos os elementos da pilha                    |
| `Contains(item)`    | Verifica se o item existe na pilha                    |
| `CopyTo(array, index)` | Copia os elementos para um array a partir de um índice |
| `Count`             | Retorna o número de elementos                         |
| `Peek()`            | Retorna o item do topo sem removê-lo                 |
| `Pop()`             | Remove e retorna o item do topo                       |
| `Push(item)`        | Adiciona um item no topo da pilha                     |
| `ToArray()`         | Retorna um array com os elementos da pilha           |
| `TrimExcess()`      | Reduz a capacidade para o número real de elementos   |
 
*/

// métodos de criação diferentes

Stack<int> numeros = new Stack<int>();
numeros.Push(1);

int[] array1 = new int[] { 2, 6, 8, 3};
Stack<int> pilha1 = new Stack<int>(array1);

var impares = new Stack<int>(3);
impares.Push(1);
impares.Push(3);
impares.Push(5);

foreach(var item in numeros)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (var item in array1)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (var item in impares)
{
    Console.WriteLine(item);
}