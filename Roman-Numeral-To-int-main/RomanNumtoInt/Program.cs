using System;
using System.Collections.Generic;

namespace RomanNumtoInt
{
    class Program
    {
        public static int ParseRomanNumeral(string num)
        {
            var RomanNums = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int[] arr = new int[num.Length];
            //put each roman numeral into an array in there number form
            for (int i = 0; i < num.Length; i++)
            {
                arr[i] = RomanNums[num[i]];
            }
            //check for numbers to take away from e.g. IX = 9 
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 != arr.Length)
                {
                    if (arr[i] < arr[i + 1])//arr[i] = front val (i+1 = back)
                    {
                       
                        int val = arr[i];
                        int valCounter = 1;
                        arr[i] = 0;
                        if (i > 0)
                        {
                            if (val == arr[i - 1])
                            {
                                valCounter++;
                                arr[i - 1] = 0;
                            }
                        }
                        if (i > 1)
                        {
                            if (val == arr[i - 2])
                            {
                                valCounter++;
                                arr[i - 2] = 0;
                            }
                        }
                        arr[i + 1] = arr[i + 1] - (valCounter * val);
                    }
                }
            }
            int arrCounter = 0;
            foreach (int val in arr)
            {
                arrCounter += val;
            }
            
            return arrCounter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ParseRomanNumeral("LIV"));// ➞ 7
            switch ("LIV") {
                case "Liv":
            }
        }
    }
}
