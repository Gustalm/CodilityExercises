using System;
using System.Linq;

namespace PermMissingEleme
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(new int[] { 2,4 });
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int[] A)
        {
            var ordered = A.OrderBy(x => x).ToList();

            if (ordered.Count == 1 && ordered[0] == 2)
                return 1;

            for (int i = 0; i < ordered.Count() - 1; i++)
            {
                if (ordered[i] + 1 != ordered[i + 1])
                    return ordered[i] + 1;
            }

            return 0;
        }
    }
}
