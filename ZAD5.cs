using System;

class Program
{
    static bool IsPalindrome(long n)
    {
        string s = n.ToString();

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - 1 - i])
                return false;
        }

        return true;
    }

    static long Reverse(long n)
    {
        long result = 0;

        while (n > 0)
        {
            result = result * 10 + n % 10;
            n /= 10;
        }

        return result;
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            long n = long.Parse(Console.ReadLine());
            int additions = 0;

            while (!IsPalindrome(n))
            {
                n += Reverse(n);
                additions++;
            }

            Console.WriteLine(n + " " + additions);
        }
    }
}
