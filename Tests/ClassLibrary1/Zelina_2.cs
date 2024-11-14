using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Zelina_2
    {
        public static void Main(string[] args)
        {
            int n;
            string[] str = File.ReadAllLines(args[0]);
            n = int.Parse(str[0]);
            if (str.Length - 1 == n)
            {
                StreamWriter wr = new StreamWriter(args[1]);
                for (int i = 1; i <= n; i++)
                {
                    bool b = true;
                    string d = str[i].ToUpper();
                    char[] slovo = d.ToCharArray();
                    Array.Reverse(slovo);
                    for (int j = 0; j < slovo.Length; j++)
                    {
                        if (d[j] == slovo[j]) { b = true; }
                        else { b = false; wr.WriteLine("NO", args[1]); break; }
                    }
                    if (b)
                    {
                        wr.WriteLine("YES", args[1]);
                    }
                }

                wr.Close();
            }
        }
    }
}
