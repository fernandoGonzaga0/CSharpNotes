/*

Serialização binária (obsoleta) -> os campos públicos e privados do objeto e o nome da clase, incluindo o assembly que contém a classe, são convertidos em um 'fluxo de bytes' que é então gravado em um fluxo de dados.

Quando o objeto for desserializado, um clone exato do objeto original será criado.

Para serializar um objeto como uma classe, você deve aplicar o atributo Serializable.

*/