using System;

class Program
{
    static void Main()
    {
        int preco = int.Parse(Console.ReadLine());
        int quantidade = int.Parse(Console.ReadLine());

        int total = preco * quantidade;

        Console.WriteLine(total);
    }
}