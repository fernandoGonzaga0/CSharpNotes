using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_indexadores;

public class Time
{
    // definir os limites do array
    string[] valor = new string[10];

    public string this[int i]
    {
        get // define a lógica para retornar o valor armazenado
        {
            if (i >= 0 && i < valor.Length)
            {
                // retornando o valor
                return valor[i];
            }
            else
            {
                return "Erro";
            }
        }
        set
        {
            if (i>= 0 && i < valor.Length)
            {
                // atribuir valor
                valor[i] = value;
            }
        }
    }
}