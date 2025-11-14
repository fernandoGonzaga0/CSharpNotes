// Serialização XML
using System.Xml.Serialization;

using _3_serializacao_XML;

// código para serializar a classe Aluno
Aluno aluno1 = new Aluno(1001, "Fernando", "fernandooliv2106@gmail.com", 25);

// criando caminhoArquivo
string caminhoArquivo = @"C:\dados\Serializacao\AlunoSerializado.xml";

// criando um XML 
XmlSerializer serializer = new XmlSerializer(typeof(Aluno));
using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
    serializer.Serialize(writer, aluno1);
}
Console.WriteLine("Objeto serializado para XML com sucesso!");
Console.ReadKey();