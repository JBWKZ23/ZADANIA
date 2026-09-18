using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        while (T-- > 0)
        {
            int N = int.Parse(Console.ReadLine());

            int[] measurements = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                measurements[i] = int.Parse(Console.ReadLine());
                sum += measurements[i];
            }

            bool[] dp = new bool[sum + 1];
            dp[0] = true;

            int currentSum = 0;

            foreach (int x in measurements)
            {
                for (int s = currentSum; s >= 0; s--)
                {
                    if (dp[s])
                    {
                        dp[s + x] = true;
                    }
                }

                currentSum += x;
            }

            int best = 0;

            for (int s = 0; s <= sum / 2; s++)
            {
                if (dp[s])
                {
                    best = s;
                }
            }
            int minSpeed = sum - 2 * best;
            int maxSpeed = sum;

            Console.WriteLine($"{minSpeed} {maxSpeed}");
        }
    }
}