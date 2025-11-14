/*

List -> É uma coleção de objetos fortemente tipados que podem ser acessados usando um índice que inicia em zero, e possui métodos para classificar, 
pesquisar, modificar e manipular listas.
 
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
    // InsertRange(int index, ICollection) -> adicioina a coleção de elemntos na lista na posição do índice especificado

// Removendo elementos

    //Remove(Object Value) -> remove a primeira ocorrência de um objeto específico
    // RemoveAt(nt index) -> remove o elemento no índice especificado
    // RemoveRange(int index, int count) -> remove um número defnido de elementos a partir de um índice especificado.

// Iteração usando laço for

    // Count na lista -> for (int i = 0; i < lista.Count; i++) {}