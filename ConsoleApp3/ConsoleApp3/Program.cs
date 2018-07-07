using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5325;
            int b = -321;
            anotherSwap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        private static int Get(int number)
        {
            return number % 10;
        }

        private static int nGet(int number, int n)
        {
            int result;
            for (int i = 10; ; i *= 10, n--)
            {
                if (n == 1)
                {
                    result = Get(number);
                    break;
                }
                number /= 10;
            }
            return result;
        }

        private static int SumOfAllDigits(int number)
        {
            int result = 0;
            for (int i = 1; i <= number.ToString().Length; i++)
            {
                result += nGet(number, i);
            }
            return result;
        }

        private static void swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        private static int random(int a, int b)
        {
            Random ran = new Random();
            return ran.Next(a, b);
        }

        private static void sort(int[] arr)
        {
            if (arr.Length == 1)
                return;
            bool swaped = true;
            while (swaped)
            {
                swaped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swaped = true;
                    }
                }
            }
        }

        private static void remove(int[] wholeArr, int[] arrayOfRemoving)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < arrayOfRemoving.Length; i++)
            {
                temp.Add(arrayOfRemoving[i]);
            }
            List<int> result = new List<int>();
            for (int i = 0; i < wholeArr.Length; i++)
            {
                if (!temp.Contains(wholeArr[i]))
                    result.Add(wholeArr[i]);
            }
            wholeArr = result.ToArray();
        }

        private static bool IsPermutation(string s1, string s2)
        {
            bool result = true;
            string text1 = s1;
            string text2 = s2;
            if (s1.Length != s2.Length)
                return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (!text2.Contains((s1[i].ToString())))
                {
                    result = false;
                    break;
                }
                text2 = text2.Remove(text2.IndexOf(s1[i].ToString()), 1);
            }

            for (int i = 0; i < s1.Length; i++)
            {
                if (!text1.Contains((s2[i].ToString())))
                {
                    result = false;
                    break;
                }
                text1 = text1.Remove(text1.IndexOf(s1[i].ToString()), 1);
            }
            return result;
        }

        private int majority(int[] arr)
        {
            int max = arr[0];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]] = map[arr[i]] + 1;
                else
                    map.Add(arr[i], 1);
            }
            foreach (int number in map.Keys)
            {
                if (map[number] > max)
                    max = map[number];
            }
            return max;
        }

        private static void anotherSwap(ref int a, ref int b)
        {
            a = (int)sumWithBitwsie((uint)a, (uint)b);
            b = subtractWithBitwise(a, b);
            a = subtractWithBitwise(a, b);
        }

        private static uint sumWithBitwsie(uint a, uint b)
        {
            uint carry = a & b;
            uint result = a ^ b;
            while (carry != 0)
            {
                uint shiftedcarry = carry << 1;
                carry = result & shiftedcarry;
                result ^= shiftedcarry;
            }
            return result;
        }

        private static int subtractWithBitwise(int x, int y)
        {
            while (y != 0)
            {
                int borrow = (~x) & y;
                x = x ^ y;
                y = borrow << 1;
            }
            return x;
        }

    }
}
