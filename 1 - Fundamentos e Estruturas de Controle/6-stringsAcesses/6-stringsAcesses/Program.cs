/*
 
 STRING ACCESS

É possível acessar posições de caracteres em uma string da seguinte maneira -> strig[posicaoDoCaractere].

Também conseguimos obter partes de uma string a partir de um caractere, fazendo com que a partir dele seja registrada outra string. 
  
*/

namespace System;

class Program
{
    static void Main()
    {
        // OBTENDO O SOBRENOME

        string nome = "Fernando Gonzaga";

        int charPosition = nome.IndexOf(" "); // pegando o espaço como divisior inicial entre nome e sobrenome (O VALOR É UM NÚMERO)

        string sobrenome = nome.Substring(charPosition + 1); // substring pega o caractere de charPosition e continua até o final da string nome. (coloquei +1 para iniciar diretamente no sobrenome)

        Console.WriteLine(sobrenome);
    }
}