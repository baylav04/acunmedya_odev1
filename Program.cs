//odev1.2

using System;

class Program
{
    static void Main()
    {
        Console.Write("İlk sayıyı girin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İşlem seçin (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+': Console.WriteLine($"Sonuç: {num1 + num2}"); break;
            case '-': Console.WriteLine($"Sonuç: {num1 - num2}"); break;
            case '*': Console.WriteLine($"Sonuç: {num1 * num2}"); break;
            case '/':
                if (num2 != 0)
                    Console.WriteLine($"Sonuç: {num1 / num2}");
                else
                    Console.WriteLine("Bir sayı 0'a bölünemez!");
                break;
            default: Console.WriteLine("Geçersiz işlem!"); break;
        }
    }
}