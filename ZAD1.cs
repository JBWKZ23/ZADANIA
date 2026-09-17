using System;
namespace cw1;

class Program
{
    static void Main(String[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int liczba = int.Parse(Console.ReadLine());
            bool liczbaP = true;
            if (liczba == 0 || liczba == 1) liczbaP = false;
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0)
                {
                    liczbaP = false;
                    break;
                }
            }
            if (liczbaP == true) Console.WriteLine("TAK");
            else Console.WriteLine("NIE");
        }
    }
}