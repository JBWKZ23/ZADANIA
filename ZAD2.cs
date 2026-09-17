using System;

class Program
{
    static void Main()
    {
        int D = int.Parse(Console.ReadLine());

        for (int i = 0; i < D; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n >= 10)
            {
                Console.WriteLine("0 0");
            }
            else
            {

                int wynik = 1;


                for (int j = 2; j <= n; j++)
                {
                    wynik = (wynik * j) % 100;
                }

                Console.WriteLine($"{wynik / 10} {wynik % 10}");
            }
        }
    }
}
