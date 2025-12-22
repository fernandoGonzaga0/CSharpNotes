/*

List -> É uma coleção de objetos fortemente tipados que podem ser acessados usando um índice que inicia em zero, e possui métodos para classificar, 
pesquisar, modificar e manipular listas.

Esta coleção é a versão genérica da coleção ArrayList, sendo equivalente a ela, e está presente no namespace System.Collections.Generic.

A classe List<T> pode ser usada para criar uma coleção de tipos diferentes, onde T representa o tipo do objeto que pode ser inteiro, string, double, e também pode ser um tipo complexo como uma classe definida pelo usuário.

Essa List<T> inicia vazia e seus elementos são alocados sob demanda. São também tipos de referência: uma variável refere-se ao objeto real, que deve ser instanciado na memória Heap.

*/

using System;

// declaração e inicialização
List<string> nomes = new();

// Adicionando na list

    // add -> adiciona no final
    nomes.Add("Fernando");
    nomes.Add("Maria");
    nomes.Add("Sara");
    nomes.Add("Paulo");

    // AddRange(ICollection) -> adiciona a coleção de elementos ao final da lista
    // InsertRange(int index, ICollection) -> adicioina a coleção de elementos na lista na posição do índice especificado

// Removendo elementos

    //Remove(Object Value) -> remove a primeira ocorrência de um objeto específico
    // RemoveAt(nt index) -> remove o elemento no índice especificado
    // RemoveRange(int index, int count) -> remove um número defnido de elementos a partir de um índice especificado.

// Iteração usando laço for

    // Count na lista -> for (int i = 0; i < lista.Count; i++) {}