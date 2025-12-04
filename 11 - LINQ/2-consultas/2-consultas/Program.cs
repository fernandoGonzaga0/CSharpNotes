/*

----- Sintaxe de método -------

Vantagens: 

    - A sintaxe da consulta é convertida automaticamente para a sintaxe de método no momento da compilação.
    - Nem todos os métodos LINQ podem ser utilizados com sintaxe de consulta.
    - A sintaxe de método é estilisticamente mais semelhante ao código C#.

*/

using _2_consultas;

Console.WriteLine("---- LINQ, Filtrar dados ----\n");

// numeros = 1, 2, 4, 8, 16, 32, 64, 28, 256, 512
var numeros = FonteDados.GetNumeros();

// 1° forma de consulta e exibição -> lambda e uma condição (retorna boolean + o valor em si para resultado1)
var resultado1 = numeros.Where(n => n < 10);
Console.WriteLine(string.Join(" | ", resultado1));

// 2° forma de consulta e exibição com várias condições 
var resultado2 = numeros.Where(n => n > 1 && n!=4 && n <20);
Console.WriteLine(string.Join(" | ", resultado2));

// 3° forma de consulta -> usando uma variável para exclusão de dados
var listaNegra = FonteDados.GetListaNegra(); //16, 128, 512
var resultado3 = numeros.Where( n => !listaNegra.Contains(n));
Console.WriteLine(string.Join(" | ", resultado3));

