using _3_desserializacao_XML;
using System.Xml.Serialization;

string caminhoArquivo = @"C:\dados\Serializacao\AlunoSerializado.xml";

XmlSerializer serializer = new XmlSerializer(typeof(Aluno));

using (StreamReader reader = new StreamReader(caminhoArquivo))
{
    var aluno = (Aluno)serializer.Deserialize(reader);
    Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, Email: {aluno.Email}, Idade: {aluno.Idade}");
}

Console.ReadKey();