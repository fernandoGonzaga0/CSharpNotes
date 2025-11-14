/*
 
Conceitos: 

        boxing -> é a conversão de um Value Type para um Reference Type
                    
                   int num = 23;
                   Object obj = num;

        unboxing -> é a conversão de um Reference Type para um Value Type
                    
                   int num = 23;
                   Object obj = num; 
                   int i = (int)obj;

 */

// ArrayList
using System.Collections;

ArrayList lista = new ArrayList();
lista.Add(3);                           // boxing
lista.Add(245);                         // boxing

// recuperar valor
var elemento = lista[0];                // unboxing
int item = (int)lista[1];               // unboxing

// List<T> não faz validação em boxing e unboxing por ser tipada, logo, não é necessário fazer as validações que ArrayList aplica. 
// Atualmente o ideal é sempre criar listas/coleções com List<T>