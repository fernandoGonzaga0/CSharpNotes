/*
 
Um ArrayList é uma coleção não genérica cujo tamanho pode ser alterado dinamicamente e que armazena elementos de vários tipos de dados.

A classe ArrayList está no namespace System.Collections e possui 3 construtores usados para criá-la:

i) ArrayList() -> é usado para criar uma instância da classe ArrayList que está vazia e sem capacidade inicial (capacity e count).
 
ii) ArrayList(Int32) -> cria uma instância da classe ArrayList que está vazia e tem capacidade inicial especificada.

iii) ArrayList(ICollection) -> cria uma lista de array inicializada com elementos da coleção especificada 

Sintaxe: 

var lista = new ArrayList() {"Fernando", 25, 2000, "Solteiro"}

 */

using System.Collections;

// DECLARAÇõES E INICIALIZAÇÃO

    // forma 1
    ArrayList lista;
    lista = new ArrayList();

    // forma 2
    ArrayList lista1 = new ArrayList();

    // forma 3
    var lista2 = new ArrayList();

    // forma 4
    ArrayList lista3 = new();

// ADICIONANDO ELEMENTOS

    // forma 1 - Add (adiciona no final do ArrayList)
    var nomes = new ArrayList() { "Fernando", "Lucas", "Pedro"};
    foreach (var item in nomes){Console.Write(item);}
    nomes.Add("Sara");
    foreach (var item in nomes) { Console.Write(item); }

// forma 2 - Insert(int index, Object value) -> permite incluir um elemento em qualquer posição usando um índice
    nomes.Insert(1, "Joel");
    foreach (var item in nomes){Console.Write(item);}

    // OBS: é possível adicionar arrayList em arrayList, basta usar AddRange e InsertRange(int index, Object value) como fizemos acima

// REMOVENDO ELEMENTOS

    // forma 1 -> Remove(Object value) remove a primeira ocorência de um objeto específico
    // forma 2 -> RemoveAt(int index) remove o elemento no índice
    // forma 3 -> RemoveRange(int index, int cout) remove um número definido de elementos a partir de um índice especificado
    // forma 4 -> Clear() limpa o arrayList

// BUSCA EM UM ARRAY LIST

    // método Contains() -> retorna true ou false
    // var busca1 = lista.(Contains(5)