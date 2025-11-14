/*
 
VARIÁVEIS

Principais tipos de variáveis em C#

int - armazena inteiros 
double - armazena numeros flutuantes (com decimais), como 21.456
char - armazena caracteres únicos, como 'a'. Devem estar entre áspas únicas.
string - armazena texto, deve estar entre áspas duplas.
bool - armazena valores de dois estados, verdadeiro ou falso

Sintaxe para declaração de variáveis:

type variableName = value;
 
 */

namespace System;

class Program
{
    static void Main()
    {
        int x, y, z;
        x = y = z = 7;

        Console.WriteLine(x + y + z);
    }
}