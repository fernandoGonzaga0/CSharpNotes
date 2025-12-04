/*

Um indexador permite que uma classe/struct seja acessada como se fosse um array. Ele define como os objetos dessa classe respondem ao uso de colchetes [].

Em vez de chamar métodos como GetItem(2) ou SetItem(0, valor), você pode usar obj[2].

Quando você define um indexador para uma classe, essa classe se comporta como um array virtual e podemos acessar a 'instância da classe' usando o operador de acesso ao array ([]) e também usar índices para acessar e atribuir valores como nos arrays.

Utilidade -> fornecer uma sitaxe para acessar, atráves do índice, itens de um objeto que represente uma coleção.

*/


using _13_indexadores;

Time time = new Time();

// atribuindo valores = get
time[1] = "Corinthians";
time[3] = "Vasco";
time[5] = "Fluminense";
time[11] = "Bahia";

// obtendo os valores = set
string valor1 = time[1];
string valor2 = time[2];
string valor3 = time[3];
string valor4 = time[4];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

Console.ReadKey();