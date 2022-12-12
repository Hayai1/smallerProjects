using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
          
           double denNum = binToDen(Console.ReadLine());
           Console.WriteLine(denNum);
        }

        static double binToDen(string binNum)
        {
            double denNum = 0;
            int i = 0;
            for (int position = binNum.Length-1; position > -1; position--)
            {
                if (Convert.ToString(binNum[position]) == "1")
                {
                    
                    denNum = Math.Pow(2, i) + denNum;
                }
                i++;
            }
            return denNum;
        }
    }
}