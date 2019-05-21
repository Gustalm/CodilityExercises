using System;
using System.Collections.Generic;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(32);
            solutiontes(new string[] { "0000", "0", "11", "1111", "001", "100000", "1001", "1", "", "1000000010001", "011101110011010001" });

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int N)
        {
            var binary = Convert.ToString(N, 2);

            var maxGap = 0;
            var oneIndexes = new List<int>();

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                    oneIndexes.Add(i);
            }

            if (oneIndexes.Count <= 1)
                return 0;

            for (int i = 0; i < oneIndexes.Count - 1; i++)
            {
                var currentGap = (oneIndexes[i + 1] - oneIndexes[i]) - 1;
                maxGap = currentGap > maxGap ? currentGap : maxGap;
            }

            return maxGap;
        }


        public static void solutiontes(IEnumerable<string> N)
        {
            //var binary = Convert.ToString(N, 2);

            foreach (var item in N)
            {
                var binary = item;
                var maxGap = 0;
                var oneIndexes = new List<int>();

                for (int i = 0; i < binary.Length; i++)
                {
                    if (binary[i] == '1')
                        oneIndexes.Add(i);
                }

                if (oneIndexes.Count <= 1)
                    Console.WriteLine(item +" "+ 0);

                for (int i = 0; i < oneIndexes.Count - 1; i++)
                {
                    var currentGap = (oneIndexes[i + 1] - oneIndexes[i]) - 1;
                    maxGap = currentGap > maxGap ? currentGap : maxGap;
                }

                Console.WriteLine(item + " " + maxGap);
            }
        }
    }
}
