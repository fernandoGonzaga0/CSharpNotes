/*
 
MÉTODOS COM RETORNO

Os métodos podem retornar um valor para o chamador.

Se o tipo de retorno (listado antes do nome do método) não for void, o método poderá retornar um valor usando a instrução return.
 
*/

public class Somar
{
    public int Soma(int numero1, int numero2)
    {
        return numero1 + numero2; // criamos o retorno sendo uma soma
    }
}

class Program
{
    static void Main()
    {
        Somar somaObjeto = new(); // criando uma instância da classe (objeto chamado somaObjeto)

       var valor = somaObjeto.Soma(2, 5); // adicionando em valor a execução do método Soma da classe Somar

        Console.WriteLine(valor); // valor da soma entre 2 e 5 -> 7
    }
    
}