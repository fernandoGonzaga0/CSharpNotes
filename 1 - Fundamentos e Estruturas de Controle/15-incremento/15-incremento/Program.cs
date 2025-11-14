Console.WriteLine("Operadores de incremento\n");

int x = 0;

Console.WriteLine($"Valor inicial -> x = {x}\n");

// pós-incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine("Pós incremento (x++):\nx++ + 10 = " + resultado1 + ", x = " + x); // 0 + 10 = 10 | após a soma, x receberá 1


// pré-incremento -> incrementa e depois resolve
x = 0;
Console.WriteLine($"\nResetando -> x = {x}\n");

int resultado2 = ++x + 10; // 0++ = 1 | 1 + 10 = 11
Console.WriteLine("Pré-incremento (++x):\n ++x + 10 = " + resultado2 + ", x = " + x); 