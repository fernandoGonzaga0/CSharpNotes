/*
 
São estruturas de dados que permitem que os dados sejam acessados, mas não modificados. Estão presentes no namespace System.Collections.ObjectModel.


| Propriedade / Método      | Descrição rápida                                           |
|---------------------------|------------------------------------------------------------|
| `Count`                   | Retorna o número de elementos                              |
| `Item[index]`             | Acessa o item pelo índice (`this[index]`)                  |
| `Contains(item)`          | Verifica se o item existe                                  |
| `IndexOf(item)`           | Retorna o índice do item                                   |
| `CopyTo(array, index)`    | Copia os elementos para um array a partir de um índice     |
| `GetEnumerator()`         | Retorna um enumerador para iterar sobre os elementos       |
| `IsReadOnly`              | Sempre retorna `true`                                      |

*/

using System.Collections.ObjectModel;

var planetas = new List<string>()
{
    "Mercúrio", "Vênus", "Terra", "Marte"
};

var listaPlanetas = new ReadOnlyCollection<string>(planetas);
var novaLista = planetas.AsReadOnly(); // setando novaLista como apenas leitura

Console.WriteLine("\nPlanetas não gasosos do sistema solar:");
foreach(var planeta in listaPlanetas)
{
    Console.Write($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");

Console.WriteLine($"Júpter está na coleção? ");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");

Console.WriteLine($"\nPlaneta de índice 3: {listaPlanetas[3]}");

Console.WriteLine($"\nÍndice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

// qualquer alteração na lista planetas resultará em alterações na novaLista, por ela ser um reflexo da primeira