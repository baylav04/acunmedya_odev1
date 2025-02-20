//ODEV1

using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Sayı pozitiftir.");
        else if (num < 0)
            Console.WriteLine("Sayı negatiftir.");
        else
            Console.WriteLine("Sayı sıfırdır.");
    }
}