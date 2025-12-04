/*

Language integrated query (LINQ) é um poderoso conjunto de tecnologias baseado na integração de recursos de consulta na linguagem C#.

A LINQ fornece uma experiência de consulta consistente para consultar objetos, bancos de dados relacionais, XML, entidades e outras fontes de dados.

Desvantagens -> consultas muito complexas são difíceis de escrever; não aproveita ao máximo os recursos da SQL, como o plano de execução em cache para o procedimento armazenado; consultas mal escritas tendem a ter um desempenho pior; alterações nas consultas exigem recompilar a aplicação e refazer o deploy.

*/

Console.WriteLine("--- LINQ ---\n");

IList<string> frutas = new List<string>() { "Banana", "Maçã", "Pera", "Uva", "Laranja"};

// query syntax
var resultado = from f in frutas
                where f.Contains('n')
                select f;

Console.WriteLine(String.Join(" | ", resultado));

// method syntax
var resultado2 = frutas.Where(f2 => f2.Contains('j'));
Console.WriteLine("\n" + resultado2);

Console.ReadKey();