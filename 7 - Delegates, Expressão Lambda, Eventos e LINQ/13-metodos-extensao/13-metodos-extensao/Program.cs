/*
 
Métodos de extensão permitem estender a funcionalidade de um tipo existente sem criar um novo tipo derivado, recompilar ou modificar o tipo original. 

São um tipo especial de método estático chamado como se fosse um método de instância no tipo estendido. 

Eles são úteis para estender a funcionalidade de tipos existentes, como classes da biblioteca padrão ou classes definidas por outras bibliotecas de terceiros.

Regras: 

i) Crie uma classe estática para conter o método de extensão. Esta classe deve estar visível para o código cliente.

ii) Implemente o método de extensão como um método estático com pelo menos a mesma visibilidade da classe que o contém.

iii) O primeiro parâmetro do método especifica o tipo no qual o método opera. Ele deve ser precedido pelo modificador this.
 
*/

// adicionando um método de extensão chamado 'InverteString' para a classe string, que nos permitirá inverter uma string.

public static class StringExtensions     // classe estática pública
{
    public static string InverteString(this string str) // método estático público. A palavra this indica que este método é uma extensão para o tipo string.
    {
        char[] charArray = str.ToCharArray();           // ToCharArray converse a string para um array de char
        Array.Reverse(charArray);                       // reverse inverte o array de caracteres
        return new string(charArray);                   // 
    }
}

public class Program
{
    public static void Main()
    {
        string nome = "Fernando Gonzaga";
        string stringInvertida = nome.InverteString();
        Console.WriteLine(stringInvertida);
    }
}