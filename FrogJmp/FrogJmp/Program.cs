using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(10, 100, 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int solution(int X, int Y, int D)
        {
            var distanceToJump = Y - X;
            if (distanceToJump <= 0)
                return 0;

            var jumpsNecessary = (double)distanceToJump / D;
            return Convert.ToInt32(Math.Ceiling(jumpsNecessary));
        }
    }
}
