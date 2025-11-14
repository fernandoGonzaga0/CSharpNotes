/*

Data type armazena o tipo e tamanho de um dado, 
 
int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
bool	1 byte	Stores true or false values
char	2 bytes	Stores a single character/letter, surrounded by single quotes
string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
 
 */

// EXEMPLO DE CONVERSÃO MANUAL ENTRE DOIS TIPOS DE DADOS

namespace System;

class Program
{
    static void Main()
    {
        double myDouble = 4.21;

        int myInt = (int) myDouble;

        Console.WriteLine($"Double: {myDouble}\nInt: {myInt}");

    }
}

/*
 
 É possível também coverter datatypes explicitamente usando os seguintes métodos:

Covert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int), Convert.ToInt64 (long).
 
 */