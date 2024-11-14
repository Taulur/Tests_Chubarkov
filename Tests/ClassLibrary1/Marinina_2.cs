using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Marinina_2
    {
        static bool PalindromProverka(string word)
        {
            string upper = word.ToUpper();
            for (int i = 0; i < upper.Length / 2; i++)
            {
                if (upper[i] != upper[upper.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
            public static void Main(string[] args)
        {
                StreamReader read = new StreamReader(args[0]);
                StreamWriter write = new StreamWriter(args[1]);
                int s = int.Parse(read.ReadLine());
                string[] words = new string[s];
                for (int i = 0; i < s; i++)
                {
                    words[i] = read.ReadLine();
                }
                foreach (string word in words)
                {
                    if (PalindromProverka(word))
                    {
                        write.WriteLine("YES");
                    }
                    else
                    {
                        write.WriteLine("NO");
                    }
                }
              
                read.Close();
                write.Close();  
        }
    }
}
