// Marcos Vinicius da Silva Zimmermann

Random sorteio = new Random();
int numeroSorteado = sorteio.Next(0, 100);
int tentativa = -2;

while (tentativa != numeroSorteado)
{
Console.WriteLine("Digite um número de 0 a 99 ou -1 para desistir:");
 tentativa = int.Parse(Console.ReadLine());



if (tentativa == -1)
{
     break; 
}
if (tentativa < 0 || tentativa >99)
{
    Console.WriteLine("Valor fora da faixa permitida.");
    continue;
}
if (tentativa < numeroSorteado)
{
    Console.WriteLine("tente um numero maior");
}
else if (tentativa > numeroSorteado)
{
    Console.WriteLine("tente um numero menor");
}
else
{
    Console.WriteLine($"Parabens você acertou!, e o numero sorteado era {numeroSorteado}");
}
}