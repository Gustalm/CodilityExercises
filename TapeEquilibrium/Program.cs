using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new int[] { 3,1,2,4,3 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < A.Length -1; i++)
            {
                if (i == 0)
                    continue;

                dic.Add(A[i], dic.Sum(x => x.Value) + A[i-1]);
            }

            return dic.Min(x => x.Value);
        }
    }
}
