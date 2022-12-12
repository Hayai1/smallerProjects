using System;
using System.Collections.Generic;

namespace binToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string binNum = Console.ReadLine();
            string hexNum = Hex(binNum);
            Console.WriteLine(hexNum);
        }
        static string reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        static string Hex(string binNum)
        {
            var hexSymbols = new Dictionary<int, string>(){
            {10,"A"},
            {11,"B"},
            {12,"C"},
            {13,"D"},
            {14,"E"},
            {15,"F"}
        };
            while (binNum.Length % 4 != 0)
            {
                binNum = "0" + binNum;
            }          
            binNum = reverse(binNum);         
            int val = binNum.Length / 4;
            char[][] terms = new char[val][];
            int counter = 0;
            for (int i = 0; i < val; i++)
            {
                char[] group = { binNum[(i*4) + 0], binNum[(i * 4) + 1], binNum[(i * 4) + 2], binNum[(i * 4) + 3] };
                terms[i] = group;
                counter++;
            }            
            
            int binarySetCounter= 0;
            int digitCounter;
            string[] hexValsArr = new string[val];
            foreach (char[] i in terms)
            {              
                digitCounter = 0;
                int hexVal = 0;
                foreach (char binval in i)
                {                  
                    if (Convert.ToString(binval) == "1")
                    {
                        switch (digitCounter)
                        {
                            case 0:
                                hexVal = hexVal + 1;
                                break;
                            case 1:
                                hexVal = hexVal + 2;
                                break;
                            case 2:
                                hexVal = hexVal + 4;
                                break;
                            case 3:
                                hexVal = hexVal + 8;
                                break;
                        }
                    }
                    digitCounter++;
                }          
                if (hexVal > 9)
                {                   
                    hexValsArr[binarySetCounter] = hexSymbols[hexVal];
                }
                else
                {                    
                    hexValsArr[binarySetCounter] = Convert.ToString(hexVal);
                }
                binarySetCounter++;
            }
            string hexString = "";
            foreach (string hexval in hexValsArr)
            {
                hexString = hexString + hexval;
            }
            return reverse(hexString);
        }
    }
}
