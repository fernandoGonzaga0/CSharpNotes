// Arrays podem ter até 32 dimensões em C#

/*

Bidimensional -> tipo[,]nome;  
Tridimensional -> tipo[,,]nome; 
Quadridimensional -> tipo[,,,]nome; 
....

*/

// Para acessar os valores de um array bidimensional (ou mais), usamos o método GetLength(n), onde a primeira dimensão inicia com zero.

// LAÇO FOR
Console.WriteLine("FOR\n");
int[,] n = { { 1, 4 }, { 5, 2 } };
           
for (int i = 0; i < n.GetLength(0); i++)   // getLength(0) lê a primeira dimensão
{
    for (int j= 0;  j < n.GetLength(1); j++) // getLength(1) lê a segunda dimensão
    {
        Console.Write($"{n[i, j]}");
    }
}

// LAÇO FOREACH -> em arrays de duas dimensões, a instrução foreach processa elementos em ordem crescente de íncide.
// Os elementos são percorridos de modo a que os índices da dimensão mais à direita são aumentados primeiro, e em seguida, os da próxima dimensão à esquerda
Console.WriteLine("\n\nFOREACH\n");

int[,] numeros = { {1, 6, 3}, { 4, 6, 2 } };

foreach (var y in numeros)
{
    Console.Write($"{y}");
}
