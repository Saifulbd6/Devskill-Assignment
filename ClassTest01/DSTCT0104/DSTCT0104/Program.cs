using System;

namespace DSTCT0104
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size N=");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int sum = 0;
            int maxSum = 0, max_i = 0,max_j=0;
            int top_i = 0,bottom_i=0,left_j=0,right_j=0 ;

            Console.WriteLine("Enter "+N*N+" values for the array: ");
            int count = 0;
            for (int i = 0; i<N; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    //array[i, j]=Convert.ToInt32(Console.ReadLine());
                    array[i, j]=count++;
                }
            }

            for (int i = 0; i<N; i++)
            {
                for (int j = 0; j<N; j++)
                {
                    sum=array[i,j];

                    top_i=i-1;
                    bottom_i=i+1;
                    left_j=j-1;
                    right_j=j+1;

                    if (top_i >= 0)
                    {
                        sum+=array[top_i, j];
                    }
                    if (bottom_i <= N-1)
                    {
                        sum+=array[bottom_i, j];
                    }
                    if (left_j >=0)
                    {
                        sum+=array[i, left_j];
                    }
                    if (right_j<=N-1)
                    {
                        sum+=array[i, right_j];
                    }

                    Console.WriteLine("Sum of [{0},{1}] = {2}",i,j,sum);
                    if (maxSum<sum)
                    {
                        maxSum=sum;
                        max_i=i;
                        max_j=j;
                    }
                }

            }
            Console.WriteLine("Maximum Sum is : "+maxSum);
            Console.WriteLine("Index of Maximum Sum is : [{0},{1}]",max_i,max_j);
        }
    }
}
