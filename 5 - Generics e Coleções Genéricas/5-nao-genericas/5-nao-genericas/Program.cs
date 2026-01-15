/*

NÃO GENÉRICAS (obsoletas, conforme os próprios desenvolvedores e pela Microsoft)

As coleções não genéricas (ArrayList, HashTable, SortedList, Stack, Queue) basicamente armazenam os elementos em arrays de objetos permitindo que contenham qualquer tipo de dado.

Principais características:

    As classes das coleções não genéricas armazenam dados do tipo Object (se inserir na coleção um int, string ou double, o valor sempre será tratado como Object).
    Fazem a conversão implícita dos tipos de dados para Object.
    Realizam as operações de boxing ao incluir e unboxing ao retirar um elemento da coleção, por esse motivo, em operações grandes, sua utilização pode causar problemas de
    desempenho na aplicação -> 'um ArrayList pode levar 2x a 4x mais tempo que List<int> em operações intensivas.'
    São mais suscetíveis a exceções em tempo de execução devido a incompatibilidade entre tipos.

GENÉRICAS

As coleções genéricas (Dictionary<TKey,TValue>, SortedDictionary<TKey,TValue>, SortedList<TKey,TValue>, LinkedList<T>, HashSet<T>, Stack<T>, etc.) foram introduzidas na versão 2.0
da linguagem C# e estão presentes no namespace System.Collections.Generic, sendo coleções fortemente tipadas.

Principais vantagens:

    São fortemente tipadas (armazenam apenas um tipo de objeto) evitando erros de incompatibilidade de tipo.
    Não realizam as operações de boxing e unboxing, oferecendo um melhor desempenho.
    Facilitam a reutilização de código.

Coleções não genéricas e sua correspondente genérica:

ArrayList -> coleção dinâmica e contígua de objetos - Preferir usar List<T>

Hashtable -> Coleção de pares chave-valor não ordenada - Preferir usar a coleção Dictionary<TKey,TValue>

Queue -> Coleção de objetos First-in-first-out (FILA) - Preferir usar a coleção Queue<T>

SortedList -> Coleção de pares chave-valor ordenados - Prefira a coleção SortedList<T>

Stack -> Coleção de objetos Last-int-first-out (PILHA) - Prefira a coleção Stack<T>

*/