/*
 
Programação assíncrona -> modelo de programação que permite que o app execute várias tarefas ao mesmo tempo sem bloquear a thread principal, usando as palavras-chaves 'async/await' e a biblioteca de tarefas TPL (Task Parallel Library) do .NET. 

Programação paralela -> modelo que permite que o app execute várias tarefas ao mesmo tempo, aproveitando recursos do processador. 
 
A programação assíncrona é usada principalmente para evitar bloqueios na execução do programa. Imagine que seu aplicativo precisa:

Ler um arquivo grande do disco

Fazer uma chamada a uma API na internet

Consultar um banco de dados

Se você fizer isso de forma síncrona, a thread principal fica parada esperando a resposta. Em uma aplicação com interface gráfica, isso significa que a tela congela. Em um servidor web, significa que ele não consegue atender outros usuários enquanto espera.

Com assíncrona, você inicia a operação e libera a thread principal para continuar trabalhando. Quando a operação termina, o resultado é entregue sem travar o programa.

*/