/*

A classe Random do namespace System é usada para gerar números pseudo-aleatórios com base no valor de uma semente (seed). 

Por padrão, o construtor sem parâmetros da classe Random usa o relógio do sistema para gerar o valor de semente.

A geração de números aleatórios começa a partir de um valor de semente (seed) e se a mesma semente for usada repetidamente, a mesma série de números será gerada.

Métodos)

Next() -> retorna um número inteiro aleatório positivo dentro do intervalo padrão -2.14.483.648 a 2.147.483.647.

Next(int) -> retorna um número inteiro aleatório positivo que é menor que o valor máximo definido.
 
Next(int, int) -> retorna um número inteiro aleatório positivo dentro do intervalo mínimo e máximo definido (inclui o mínimo e exclui o máximo).

NextDouble() -> gera um número de ponto flutuante aleatório que é maior ou igual a 0,0 e menor que 1,0.

*/

Random aleatorio1 = new Random();

Console.WriteLine(aleatorio1.Next()); // retorna um número aleatório

Console.WriteLine(aleatorio1.Next(145)); // máx de 145 

Console.WriteLine(aleatorio1.Next(100, 560)); // dentro do intervalo

Random aleatorio2 = new Random();

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(aleatorio2.NextDouble()); // double
}