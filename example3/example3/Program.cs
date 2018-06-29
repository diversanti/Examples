using System;
using System.Reflection;
using System.Text;
namespace example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumBigNumbers("10235", "424234"));
            Console.ReadKey();
        }
        private static String SumBigNumbers(String a, String b)
        {
            StringBuilder sum = new StringBuilder();
            StringBuilder MyFirstNumber = new StringBuilder();
            StringBuilder MySecondNumber = new StringBuilder();
            if (a.Length >= b.Length)
            {
                for (int i = a.Length - 1; i > b.Length - 1; i--)
                {
                    MySecondNumber.Append("0");
                }
                MySecondNumber.Append(b);
                b = MySecondNumber.ToString();
            }
                
            else
            {
                for (int i = b.Length - 1; i > a.Length - 1; i--)
                {
                    MyFirstNumber.Append("0");
                }
                MyFirstNumber.Append(a);
                a = MyFirstNumber.ToString();
            }

            for (int i = 0; i < a.Length; i++)
            {
                sum.Append(Char.GetNumericValue(a[i]) + Char.GetNumericValue(b[i]));
            }
            return sum.ToString();
        }

        private class Stringbuilder
        {
        }
    }
}
