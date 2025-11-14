/*

A composição e agregação são técnicas de programação que permitem que uma classe 'contenha' um ou mais objetos de outras classes para formar um grande
objeto realizando alguma funcionalidades específicas. 

O contêiner é a classe pai e as classes contidas na superclasse são classes filhas, esse relacionamento é do tipo "tem-um". A herança, por exemplo, é do 
tipo de relacionamento 'é-um'.

Composição é um princípio da programação orientada a objetos onde uma classe possui uma ou mais instâncias de outras classes como parte de sua estrutura. 
Em vez de herdar comportamentos, ela usa outros objetos para realizar tarefas. Em outras palavras: "tem um" é diferente de "é um".
 
 */

// Ex: a classe Casa contém referências às classes Telhado e Alicerce. Com isso, podemos escolher quais métodos/propriedades serão enviadas 
// à classe composta, ao invés de herdar todas as funcionalidades das classes. 

public class Casa
{
    private readonly Telhado _telhado;
    private readonly Alicerce _alicerce;

    public Casa()
    {
        _telhado = new Telhado();
        _alicerce = new Alicerce();
    }

}

public class Telhado
{
    //
}

public class Alicerce
{
    //
}