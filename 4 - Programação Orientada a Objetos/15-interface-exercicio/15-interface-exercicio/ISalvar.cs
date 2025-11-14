using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esse arquivo conterá a interface que será utilizada nas classes derivadas (Json e XML).

namespace _15_interface_exercicio;

public interface ISalvar
{
    void Salvar();

    // Incluir o método não abstrato Compactar() na interface -> o método NÃO SERÁ HERDADO NAS CLASSES DERIVADAS, SERÁ NECESSÁRIO INSTANCIAR A PARTIR DA CLASSE
    void Compactar()
    {
        Console.WriteLine("Compactando arquivos.");
    }
}