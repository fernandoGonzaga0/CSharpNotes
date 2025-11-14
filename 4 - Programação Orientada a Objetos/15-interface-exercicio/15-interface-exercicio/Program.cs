/*
 
Crie um programa que uas interfaces para salvar arquivos nos formatos Xml e Json.

Criar a interface ISalvar definindo o método abstrato Salvar().
Criar uma classe abstrata ArquivoBase e definir um método virtual Nome().
Criar as classes SalvarXml e SalvarJson e herdar a classe base e implementar a interface nas duas classes. 
Testar a implementação.
Incluir o método não abstrato Compactar() na interface definindo uma implementação.
Acessar este método.
 
 */

namespace _15_interface_exercicio;

public class Program()
{
    static void Main()
    {
        // Salvando Xml
        SalvarXml Xml1 = new();
        Xml1.Salvar();
        Xml1.Nome();

        // Salvando Json
        SalvarJson Json1 = new();
        Json1.Salvar();
        Json1.Nome();

        // Chamando o método Compactar() -> como ele foi declarado na interface ISalvar, ele fica 'invisível' nas classes derivada, sendo necessário
        // instanciar o objeto (seja Json ou XML) partindo da própria interface
        ISalvar Json1Compactado = new SalvarJson();
        ISalvar Xml1Compactado = new SalvarXml();
        Json1Compactado.Compactar();
        Xml1Compactado.Compactar();
    }
}