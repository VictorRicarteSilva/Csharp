// See https://aka.ms/new-console-template for more information

int numero;
Console.WriteLine("Entrada:");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Saida:");
for (int i = 0; i < numero; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}