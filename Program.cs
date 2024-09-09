const int limiteContagem = 10;
int contador = 1;

Contador();

void Contador()
{
    #pragma warning disable CA1416 
    Thread.Sleep(500);
    Console.Write($"{contador} ");
    Console.Beep(5000, 500);
    contador++;
    #pragma warning restore CA1416
    if (contador <= limiteContagem)
    {
        Contador();
    }
}