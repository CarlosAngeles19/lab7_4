using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Ingresa un número: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        Console.ReadKey();
    }
}
