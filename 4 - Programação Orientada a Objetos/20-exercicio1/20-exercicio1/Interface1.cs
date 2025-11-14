using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_exercicio1;

public interface IVeiculo
{
    public void Dirigir();
    public bool Abastecer(int LtDeGasolina);

}