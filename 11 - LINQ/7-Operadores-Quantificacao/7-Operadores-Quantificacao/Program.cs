/*

Operadores de quantificação -> são usados em uma fonte de dados quando queremos verificar se alguns ou todos os elementos atendem a uma condição ou não.

Retornam um valor booleano (true ou false) que indica se alguns ou todos os elementos na fonte de dados satisfazem a condição.

All -> Determina se todos elementos satisfazem.
Any -> Determina se pelo menos um elemento satisfaz.
Contains -> Determina se a fonte de dados contém um elemento especificado.

*/

int[] numeros = { 10, 22, 32, 44, 56, 64, 77, 78};

var possiveisTodosPares = numeros.All(n => n % 2 == 0);
var peloMenosUmPar = numeros.Any(n => n % 2 == 0);

//verificando se contém 10
var contemUmPar = numeros.Contains(10);

Console.WriteLine(possiveisTodosPares);
Console.WriteLine(peloMenosUmPar);
Console.WriteLine(contemUmPar);