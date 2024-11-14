using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Forrat_2
    {
        static bool IsPalindrome(string word)
        {
            string upperWord = word.ToUpper();
            for (int i = 0; i < upperWord.Length / 2; i++)
            {
                if (upperWord[i] != upperWord[upperWord.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(args[0]);
            StreamWriter sw = new StreamWriter(args[1]);
            int s = int.Parse(sr.ReadLine());
            string[] words = new string[s];
            for (int i = 0; i < s; i++)
            {
                words[i] = sr.ReadLine();
            }
            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    sw.WriteLine("YES");
                }
                else
                {
                    sw.WriteLine("NO");
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
