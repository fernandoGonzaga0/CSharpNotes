/*

LINQ (Language Integrated Query) é um conjunto de tecnologias baseadas na integração de recursos de consulta diretamente na linguagem C#. 

Ela inclui: documentos XML, bancos de dados relacionais (SQL Server, etc.), serviços Web e outros formatos estruturados.

Permite escrever consultas em coleções fortemente tipadas usando palavras-chave da linguagem C#, operadores familiares e com o suporte ao IntelliSense.

As consultas retornam dados como objetos.

Rotina: 

1) Definir a fonte de dados;
2) Definir a consulta LINQ;
3) Executar a consulta;

*/

                                                                    // Consultas
// 1) Consulta normal

// fonte de dados
List<string> nomes = new List<string>()
{
    "Fernando", "Ana", "Lair", "José"
};

// consulta LINQ
var resultado1 = from m in nomes                   // resultado1 será do tipo IEnumerable (somente leitura, iterável)
                where m.Contains('n')
                select m;

foreach(var item1 in resultado1)
{
    Console.WriteLine($"Nome que contém 'n' -> {item1}\n");
}

// 2) Consulta LINQ com method syntax (sintaxe de método)

// fonte de dados
List<string> cidades = new List<string>()
{
    "Pernambuco", "Rio de janeiro", "Aracaju", "Maranhão", "Sergipe", "São Paulo"
};

// consulta LINQ (com sintaxe de método)
var resultado2 = cidades.Where(m => m.Contains('j'));

foreach(var item2 in resultado2)
{
    Console.WriteLine($"Nome de cidade que contém 'j' -> {item2}\n");
}