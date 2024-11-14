using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{ 
    public class Mokeev_2
    {
       
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader(args[0]))
            {
                int n = int.Parse(reader.ReadLine());
                string[] output = new string[n];
                for (int i = 0; i < n; i++)
                {
                    string word = reader.ReadLine();
                    if (IsPolyndrom(word)) output[i] = "YES";
                    else output[i] = "NO";
                }
                File.WriteAllLines(args[1], output);
            }
        }
        static bool IsPolyndrom(string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] == word[word.Length-1-i]) continue;
                else return false;
            }
            return true;
        }
    }
}
