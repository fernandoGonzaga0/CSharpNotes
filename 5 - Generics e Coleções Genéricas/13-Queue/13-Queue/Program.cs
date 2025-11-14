/*
 
Queue<T> é uma coleção genérica de tamanho variável, modelo FILA. 

### 📌 Principais funcionalidades da `Queue<T>`

| Método / Propriedade     | Descrição rápida                                           |
|--------------------------|------------------------------------------------------------|
| `Enqueue(item)`          | Adiciona um item ao final da fila                          |
| `Dequeue()`              | Remove e retorna o item no início da fila                  |
| `Peek()`                 | Retorna o item no início da fila sem removê-lo             |
| `Contains(item)`         | Verifica se o item existe na fila                          |
| `Clear()`                | Remove todos os itens da fila                              |
| `Count`                  | Retorna o número de elementos na fila                      |
| `ToArray()`              | Converte a fila em um array                                |
| `TrimExcess()`           | Reduz a capacidade para o número real de elementos         |
| `CopyTo(array, index)`   | Copia os elementos da fila para um array a partir de índice|

*/

// Enqueue para add item no final da fila
Queue<string> diasSemana = new Queue<string>();
diasSemana.Enqueue("Sábado");
diasSemana.Enqueue("Domingo");
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");

foreach (var dia in diasSemana)
{
    Console.WriteLine("Dia inserido -> " + dia);
}