using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_polimorfismo;

public class Quadrado : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um Quadrado...");
    }
}