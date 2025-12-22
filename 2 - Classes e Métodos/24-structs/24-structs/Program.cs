/*
Struct é um tipo de valor em C#. Usado geralmente para agrupar dados relacionados, como campos e métodos, em um único tipo. 

Structs são ideais para representar objetos pequenos e imutáveis, como coordenadas, pontos no espaço, cores, etc.

Ficam armazenadas na memória stack (menor tamanho e custo operacional - são como classes mais leves).

A atribuição é feita por valor, diferente das classes onde a atribuição é feita por referência -> aula 89 minuto 5 no curso

*/

public class MinhaClasse
{
    public int x;
    public int y;
}

public struct MinhaStruct
{
    public int x;
    public int y;
}

class Program
{
    // DIAGRAMA EXPLICADO NO VÍDEO 89
    static void Main()
    {
        // instâncias da classe
        MinhaClasse classe1 = new(), classe2 = null;

        // instâncias da struct
        MinhaStruct struct1 = new(), struct2 = new();

        // atribuindo valores para struct e classes correspondentes
        classe1.x = struct1.x = 5;
        classe2.x = struct2.x = 10;

        classe2 = classe1; // referencia
        struct2 = struct1; // valor

        Console.ReadKey();
    }
}