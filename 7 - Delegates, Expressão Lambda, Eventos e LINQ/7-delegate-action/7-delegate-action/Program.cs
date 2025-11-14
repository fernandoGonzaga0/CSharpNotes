/*

Action é um delegate que representa um método que não retorna nenhum valor e pode receber de 1 a 16 argumentos do tipo T.

Ele encapsula um método que não retorna nenhum valor (void) e pode receber de zero a 16 parâmetros de entrada.

Sintaxe: delegate void Action<in T>(T obj);

*/

// Simplificando um código que dobra o valor de um número usando o delegate Action.

Action<int> dobra = x => Console.WriteLine($"Dobro de {x} = " + x * 2); // se eu não fizesse isso, seria necessário criar um método avulso Duplicar() com a ação e depois chamar

Console.WriteLine("Informe um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
dobra(numero);

Console.ReadKey();