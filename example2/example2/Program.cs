using System;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        private static int ReverseInt(int number)
        {
            int ReversedNumber = 0;
            for (int i = 1; number >= 1; i*=10)
            {
                ReversedNumber = ReversedNumber * 10 + number % 10;
                number /= 10;
            }
            return ReversedNumber;
        }
    }
}
