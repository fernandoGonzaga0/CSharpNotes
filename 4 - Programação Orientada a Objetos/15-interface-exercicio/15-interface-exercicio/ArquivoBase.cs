using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esse arquivo base conterá a classe base que será utilizada nas classes derivadas (Json e XML).

namespace _15_interface_exercicio;

public abstract class ArquivoBase // abstract impede que a classe seja instanciada | classe base
{
    public virtual void Nome() // método virtual Nome()
    {
        Console.WriteLine("Definir o nome do arquivo.");
    }
}