namespace Leetcode
{
    public class HammingDistance
    {
        public static void Main()
        {
            System.Console.WriteLine("HammingDistanceMethod between {0} and {1} is {2}", 1, 4, HammingDistanceMethod(1, 4));
        }
        public static int HammingDistanceMethod(int x, int y)
        {
            // System.Numerics.BitOperations.PopCount(x)
            // string binaryX = System.Convert.ToString(x, 2);
            // string binaryY = System.Convert.ToString(y, 2);
            // int count = 0;
            // if (binaryX.Length != binaryY.Length)
            // {
            //     return 0;
            // }
            // else
            // {
            //     for (int i = 0; i < binaryX.Length; i++)
            //     {
            //         if (System.Convert.ToBoolean(binaryX[i]) ^ System.Convert.ToBoolean(binaryY[i]))
            //         {
            //             count++;
            //         }
            //     }
            // }
            // return count;
            int xor = x ^ y;
            int distance = 0;
            while (xor != 0)
            {
                if (xor % 2 == 1)
                    distance += 1;
                xor = xor >> 1;
            }
            return distance;
        }

    }
}