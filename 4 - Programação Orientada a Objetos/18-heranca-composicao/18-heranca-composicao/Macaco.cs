using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_heranca_composicao;

public class Macaco : Animal
{
    private readonly ComportamentoAndar _comportamentoAndar; // criando uma instância da classe ComportamentoAndar e adicionando na variável _comportamentoAndar
    public Macaco(ComportamentoAndar comportamentoAndar) // ComportamentoAndar = Classe | comportamentoAndar = objeto da classe, que contém o método Andar()
    {
        _comportamentoAndar = comportamentoAndar;
    }
    public void Locomocao()
    {
        Console.Write(nameof(Macaco)); // nameof apenas escreve de fato o nome da classe, para evitar a utilização de áspas "Macaco" (se trocarmos o nome da classe, muda aqui automaticamente
        _comportamentoAndar.Andar();
    }
}