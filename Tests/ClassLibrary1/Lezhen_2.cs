using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Lezhen_2
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
            string[] OutPut = new string[int.Parse(lines[0])];
            for (int i = 0; i < int.Parse(lines[0]); i++)
            {
                string word = lines[i+1];
                string upperWord = word.ToUpper();
                bool isPalindrome = IsPalindrome(upperWord);
                if (isPalindrome)
                {
                    OutPut[i] = "YES";
                }
                else
                {
                    OutPut[i] = "NO";
                }
            }
            StreamWriter sw = new StreamWriter(args[1]);
            for (int i =0; i < OutPut.Length; i++)
            {
                sw.WriteLine(OutPut[i]);
            }
            sw.Close();
        }

        static bool IsPalindrome(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (word[i] != word[length - i - 1])
                {
                    return false; 
                }
            }
            return true; 
        }
    }
}
