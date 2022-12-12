

namespace PalindromeDescendant
{
    class Program
    {

        public static bool PalindromeDescendant(int num)
        {
            
            string numTxt = System.Convert.ToString(num);
            if (numTxt.Length % 2 != 0){
                return false;
            }    
            for (int i = 0; i < System.Math.Floor(System.Math.Log10(num) + 1)/2; i++)
            {
                if (numTxt[i] != numTxt[numTxt.Length - 1 - i])
                {
                    if (numTxt.Length <= 2)
                    {
                        return false;
                    }
                    int currentNumber = num;
                    System.Collections.Generic.List<int> digits = new System.Collections.Generic.List<int>();
                    while (currentNumber != 0)
                    {
                        digits.Add(currentNumber % 10);
                        currentNumber = currentNumber / 10;
                    }
                    digits.Reverse();
                    string newdigit = "";
                    for (int z = 0; z + 1 <= digits.Count - 1; z += 2)
                    {
                        int d = digits[z] + digits[z + 1];
                        newdigit = string.Format("{0}{1}", newdigit, d);
                    }
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    bool flag = PalindromeDescendant(System.Convert.ToInt32(newdigit));
                    return flag;
                }             
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            //PalindromeDescendant(11211230);// ➞ false
            // 11211230 ➞ 2333 ➞ 56

            //PalindromeDescendant(13001120);// ➞ true
            // 13001120 ➞ 4022 ➞ 44

            System.Console.WriteLine(PalindromeDescendant(9735));// ➞ true
            // 23336014 ➞ 5665

            //Console.WriteLine(PalindromeDescendant(1111));// ➞ true
            // Number itself is a palindrome.
        }
    }
}
