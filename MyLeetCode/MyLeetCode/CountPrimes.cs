using System;
public class CountPrimesSolution
{
    public int CountPrimes(int n)
    {
        int count = 0;

        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
                Console.WriteLine("Primary Number {0}", i);
            }
        }
        return count;
    }
}