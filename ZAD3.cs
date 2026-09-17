using System;

class Program
{
    static int ModPow(int a, int b)
    {
        int wynik = 1;
        a = a % 10;

        while (b > 0)
        {
            if (b % 2 == 1)
            {
                wynik = (wynik * a) % 10;
            }

            a = (a * a) % 10;
            b = b / 2;
        }

        return wynik;
    }

    static void Main()
    {
        int D = int.Parse(Console.ReadLine());

        for (int i = 0; i < D; i++)
        {
            string[] dane = Console.ReadLine().Split();

            int a = int.Parse(dane[0]);
            int b = int.Parse(dane[1]);

            Console.WriteLine(ModPow(a, b));
        }
    }
}
