/*
 
Enum é um tipo de dados especial definido pelo usuário. 

É uma classe especial que é definida por um conjunto de constantes nomeadas do tipo NUMÉRICO. 

O uso do tipo enum ajuda a tornar o programa mais fácil de entender e manter. 

Por padrão, os valores associados aos membros de uma enum são do tipo int. O valor também será incremental, sendo o de índice 0 igual à 1, e assim adiante.
 
*/

enum DiasDaSemana
{
    // os dias da semana são membros de enum
    Segunda,  //0
    Terça,    //1
    Quarta,   //2
    Quinta,   //3
    Sexta,    //4
    Sábado,   //5
    Domingo   //6

    // os valores dos membros são sequenciais, se mudarmos quinta para 45, sexta continuará a contagem e terá valor 46 caso não seja estabelecido outro manualmente
}

class Program
{
    static void Main()
    {
        //exibindo o nome do membro
        Console.WriteLine(DiasDaSemana.Domingo);

        //exibindo o valor do membro
        int dia1 = (int)DiasDaSemana.Domingo;
        Console.WriteLine(dia1);
    }
}