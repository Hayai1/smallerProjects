using System;

namespace dentobenindiv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 27;//num to convert bin
            string binNum ="";
            if (num == 0) { binNum = "0"; }
            while (num >=1)
            {
                int rem1 = num % 2;
                if (rem1 == 0) { binNum = (binNum + "0"); }//even
                else { binNum = (binNum + "1"); }//odd
                num = num / 2;
            }
            char[] tempArray = binNum.ToCharArray();
            Array.Reverse(tempArray);
            Console.WriteLine(new string(tempArray));
        }
    }
}
