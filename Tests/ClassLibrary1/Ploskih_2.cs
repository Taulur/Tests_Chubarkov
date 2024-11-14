using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Ploskih_2
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(args[0]);
                int n = int.Parse(lines[0]); 
                string[] results = new string[n];
              
                    for (int i = 0; i < n; i++)
                    {
                        string word = lines[i + 1].ToUpper();
                        if (IsPalindrome(word))
                        {
                            results[i] = "YES";
                        }
                        else
                        {
                            results[i] = "NO";
                        }
                    }
                    File.WriteAllLines(args[1], results);
       


            }
            catch (Exception ex)
            {
               
            }
        }

        
        static bool IsPalindrome(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false; 
                }
                left++;
                right--;
            }
            return true; 
        }
    }
}
    

