using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new int[] { -4 }, 0);

            Console.WriteLine(string.Join(" ", result));
            Console.ReadLine();
        }

        public static int[] solution(int[] A, int K)
        {
            if (A.Length == 0 || K == 0)
                return A;

            var array = new int[A.Length];

            for (int i = 0; i < K; i++)
            {
                Array.Copy(A, 0, array, 1, A.Length - 1);
                array[0] = A[A.Length - 1];
                array.CopyTo(A,0);
            }

            return array;
        }
    }
}
