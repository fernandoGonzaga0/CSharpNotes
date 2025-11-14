/*

Delegate Predicate -> representa um método que recebe um único argumento do tipo T e retorna um valor booleano. Pode ser usado para testar se um objeto satisfaz uma condição específica.

Sintaxe: public delegate bool Predicate<in T>(T obj);
 
*/

// Ex: filtrar números pares de uma lista

// usando Predicate<T> 

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> delegatePar = x => x % 2 == 0;

if (delegatePar(numero)) {
    Console.WriteLine($"O número {numero} é PAR.");
}
else
{
    Console.WriteLine($"O número {numero} é ÍMPAR.");
}

Console.ReadKey();