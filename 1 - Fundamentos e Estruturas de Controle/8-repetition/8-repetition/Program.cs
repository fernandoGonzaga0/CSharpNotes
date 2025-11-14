/*

WHILE 

while (condition) 
{
  // code block to be executed
}

DO WHILE

do 
{
  // code block to be executed
}
while (condition);


FOR

for (statement 1; statement 2, statement 3) 

    {

    // code block to be executed
    
    }

FOREACH

foreach (type variableName in arrayName) 
{
  // code block to be executed
}
 
*/

namespace System;

class Program
{
    static void Main()
    {
        string[] cars = { "Volvo", "BMW", "Porshe", "Ferrari" };

        foreach (string i in cars) // i é um ponteiro temporário de C#, usando para iterar entre os elementos do array
        {
            Console.WriteLine(i);
        }
    }
}