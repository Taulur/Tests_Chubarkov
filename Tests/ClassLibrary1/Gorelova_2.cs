using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gorelova_2
    {
        static bool Proverka(string word)
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
                string[] a = new string[s];
                for (int i = 0; i < s; i++)
                {
                    a[i] = sr.ReadLine();
                }
                foreach (string b in a)
                {
                    if (Proverka(b))
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
