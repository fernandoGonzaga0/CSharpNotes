/*
 
ARRAYS

Em C#, arrays são declarados pelo formato -> type[] name; -> string[] carros;

Para inserir valores, podemos fazer arrays literais da seguinte forma:

    string[] carros = {"Volvo", "BMW", "Ford"};

Para acessar elementos de array -> carros[0], carros[1], etc.

 
*/

using System; 

class Program
{
    static void Main()
    {
        // loop em um array

        string[] frutas = { "Maçã", "Uva", "Pêra" };

        for (int i = 0; i <= frutas.Length; i++)
        {
            
            Console.WriteLine($"{i+1}° fruta -> {frutas[i]}");
        }
    }
}