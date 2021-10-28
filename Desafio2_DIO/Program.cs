using System;

namespace Desafio2_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, x;
            Console.WriteLine("Digite a quant. de números a serem testados: ");
            n = int.Parse(Console.ReadLine());
          
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite o número {i+1}: ");
                x = int.Parse(Console.ReadLine());
                int resto = x % 2;
                if (x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (resto == 0)
                {
                    if (x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }

                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }

            }

        }
    }
}
