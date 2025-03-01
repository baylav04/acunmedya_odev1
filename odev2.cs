using System;

namespace DigitSumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int sum = CalculateDigitSum(number);
                Console.WriteLine($"Rakamların toplamı: {sum}");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı giriniz.");
            }
        }

        static int CalculateDigitSum(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            for (; number > 0; number /= 10)
            {
                sum += number % 10;
            }

            return sum;
        }
    }
}

