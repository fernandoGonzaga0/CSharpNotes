/*
 
Criar uma classe Genérica que deverá ser implementada de acordo com os seguintes requisitos:

i) ser um array genérico de uma dimensão de tamanho igual a 5;
ii) possuir um método Adicionar() responsável por adicionar qualquer tipo de objetos no array;
iii) Possuir uma propriedade Indexer como uma implementação para um laço for (usar conceito de indexador).
 
*/

public class ClasseGenerica<T>  // T pode ser qualquer tipo de dado
{
    T[] obj = new T[5];         // criando o array de T com 5 posições 
    int contador = 0;           // para mapearmos as posições de índices no array

    public void Adicionar(T item)
    {
        if (contador < 5)        // menor que 5 pois ele pode ter apenas 5 posições -> 0,1,2,3,4
        {
            obj[contador]= item; // inserindo o item na posição atual do contador
        }
        contador++;
    }
    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}

public class Program
{
    static void Main()
    {
        ClasseGenerica<int> objInt = new ClasseGenerica<int>();

        objInt.Adicionar(10);
        objInt.Adicionar(20);
        objInt.Adicionar(30);
        objInt.Adicionar(40);
        objInt.Adicionar(50);

        Console.WriteLine("Classe ClasseGenerica<T> de objetos string\n");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(objInt[i]);
        }
    }
}