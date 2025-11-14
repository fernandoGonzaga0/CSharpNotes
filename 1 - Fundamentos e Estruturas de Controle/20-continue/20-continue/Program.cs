/*

CONTINUE

É uma instrução que interrompe uma iteração (no loop) se ocorrer uma condição especificada. Retorna e verifica a condição do loop e continua com a próxima
iteração no loop.
 
*/

for (int i = 1; i <= 10; i++)
{
    if (i == 4) // obs: ponto de parada marcado na linha 12
    {
        continue; // continue faz com que a iteração seja interrompida e retorne para o laço for novamente, fazendo com que o WriteLine não leia 4
    }

    Console.WriteLine(i);
}