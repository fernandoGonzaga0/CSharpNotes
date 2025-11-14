/*

O delegate Func encapsula um método que pode possuir de 0 até 16 parâmetros e que tem um tipo de retorno.

Sintaxe -> delegate TResult Func<TInput, TOutput> | podendo ser até 16 entradas Func<int T1, in T2, ..., out TResult>(T1 arg1, T2 arg2, ...)>;

           T1,T2, ... - São os tipos dos argumentos do método encapsulado por este delegate.
           TResult - É o tipo de retorno do método encapsulado por esse delegate.
 
*/

// Ex: programa que recebe um número do tipo double e calcula a raiz quadrada retornando um double usando delegate Func.

Console.WriteLine("Diite um número");
double numero = Convert.ToDouble(Console.ReadLine());

Func<double, double> raizQuadrada = x => Math.Sqrt(x); // delegate Func

double resultado = raizQuadrada(numero);

Console.WriteLine($"A raiz quadrada de {numero} é: {resultado}");