using System;

namespace _2048
{

    class Program
    {
        public static int[] LeftSlide(int[] row)
        {
            int[] Val = { 0,0 };
            bool Flag = true;
            int pointer = 0;
            int count = 0;
            bool foundZero = false;
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != 0)
                {
                    if (row[i] == Val[0])
                    {
                        row[i] = Val[0] * 2;
                        row[Val[1]] = 0;
                        Val[0] = 0;

                    }
                    else
                    {
                        Val[0] = row[i];
                        Val[1] = i;
                    }    
                }
            }
            while (Flag)
            {
                foundZero = false;
                int pointer2;
                for (int index = 0; index < row.Length; index++)
                {
                    if (row[index] == 0)
                    {
                        pointer = index;
                        break;
                    }
                }
                for (int index = count; index < row.Length; index++)
                {
                    if (row[index] != 0)
                    {
                        row[pointer] = row[index];
                        row[index] = 0;
                        count++;
                        
                        break;
                    }
                }
                for (int index = 0; index < row.Length; index++)
                {
                     if (row[index] == 0)
                     {
                        foundZero = true;
                     }
                     if (foundZero)
                     {
                         if (row[index]  != 0)
                         {
                            pointer2 = index;
                            break;
                         }
                         else if (index == row.Length - 1)
                         {
                             Flag = false;
                         }
                     }                                             
                }   
            }
            return row;
        }
     
    static void Main(string[] args)
        {
            LeftSlide(new int[] { 2, 2, 2, 0 });// ➞ int[] { 4, 2, 0, 0 }
            // Merge left-most tiles first.

            //LeftSlide(new int[] { 2, 2, 4, 4, 8, 8 }); //➞ int[] { 4, 8, 16, 0, 0, 0 }
            // Only merge once.

            //LeftSlide(new int[] { 0, 2, 0, 2, 4 }); //➞ int[] { 4, 4, 0, 0, 0 }

            //LeftSlide(new int[] { 0, 2, 2, 8, 8, 8 });  //➞ int[] { 4, 16, 8, 0, 0, 0 }
        }
    }
}
