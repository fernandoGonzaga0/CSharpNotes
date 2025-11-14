/*

Uma expressão lambda é uma função anônima que pode ser usada para criar delegates ou expressões de árvores de expressão.

É uma maneira mais curta de representar um método anônimo usando uma sintaxe especial (sugar syntax).

São usadas para escrever métodos in-line simples e rápidos, sem precisar criar um método nomeado separado. 

Sintaxe: (parâmetros de entrada) => {expressão ou bloco de instrução};
 
*/

List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Paulo");
nomes.Add("Carlos");
nomes.Add("Sara");

// criando uma string resultado que receberá uma busca na lista por expressão lambda
string? resultado = nomes.Find(nome => nome.Equals("Carlos"));

Console.WriteLine(resultado);