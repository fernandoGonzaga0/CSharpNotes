using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_polimorfismo;

public class Circulo : Figura
{
    public override void Desenhar()
    {
        Console.WriteLine("Desenhando um círculo...");
    }
}