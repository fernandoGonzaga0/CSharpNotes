using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_heranca_composicao;

public class Pato : Animal
{
    private readonly ComportamentoVoar _comportamentoVoar;
    public Pato(ComportamentoVoar comportamentoVoar)
    {
        _comportamentoVoar = comportamentoVoar;
    }
    public void Locomocao()
    {
        Console.Write(nameof(Pato));
        _comportamentoVoar.Voar();
    }
}