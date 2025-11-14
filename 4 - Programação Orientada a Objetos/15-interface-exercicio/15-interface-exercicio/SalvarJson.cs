using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// nesse arquivo vamos criar a classe SalvarJson que herdará a classe ArquivoBase e a interface ISalvar, contendo seus próprios métodos.
// Sobre o método da classe base Nome() -> vamos usar override para sobrescrever o código setado na classe base, atendendo apenas JSON.
// Sobre o método da interface Salvar() -> como se trata de uma interface, é criada a base em ISalvar e setada aqui, atendendo apenas JSON.

namespace _15_interface_exercicio;

public class SalvarJson : ArquivoBase, ISalvar
{
    public void Salvar()
    {
        Console.WriteLine("Salvar arquivo em Json");
    }

    public override void Nome() // esse método pertence à classe ArquivoBase, setado com virtual, para alterármos aqui com override
    {
        Console.WriteLine("Definir nome Json.");
    }
}