using System;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var aox = solution(new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 2, 4, 4, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8 });
        }

        public static int solution(int[] A) => A.GroupBy(x => x).FirstOrDefault(x => x.Count() % 2 > 0).Key;
    }
}
