using System;

namespace DSTCT0103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int sum = 0;

            Console.WriteLine("Enter "+ N*N +" values for the array: ");
            for (int i = 0; i<N; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    array[i, j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i<N; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    if (i==j)
                    {
                        sum+=array[i,j];
                    }
                    if (j==(N-i-1))
                    {
                        sum+=array[i,j];
                    }
                }

            }
            Console.WriteLine("Total Sum of Diagonal elements: "+sum);
        }
    }
}
