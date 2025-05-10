using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int[] number = { 4, 7, 9, 3, 1 };

        foreach (int num in number)
        {
            soma += num; 
        }

        Console.WriteLine($"A soma total dos elementos é: {soma}");
        double media = soma / 5;
        Console.WriteLine($"A média é: {media}");
    }
}