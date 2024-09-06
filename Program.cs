const int limiteContagem = 10;
int contador = 0;

Contador();

void Contador()
{
    contador++;
    Thread.Sleep(1000);
    Console.Write($"{contador} ");
    if (contador < limiteContagem)
    {
        Contador();
    }

    else 
    {
        return;
    }
}