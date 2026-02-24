int x = 0;
for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("ingrese número: ");
    int numero = int.Parse(Console.ReadLine());
    x = x + numero;
}
Console.WriteLine($"total: {x}");