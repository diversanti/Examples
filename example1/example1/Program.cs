using System;

namespace example1
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        private int[] ArrangeArray(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    counter++;
            }
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i <= counter)
                    arr[i] = 0;
                else
                    arr[i] = 1;
            }
            return null;
        }
    }
}
