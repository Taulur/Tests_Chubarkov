using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Martynov_2
    {
        public static void Main(string[] args)
        {
            string file = args[0];
            string file2 = args[1];
           
                StreamReader ss = new StreamReader(file);

                int num = int.Parse(ss.ReadLine());
                
                StreamWriter ss2 = new StreamWriter(file2);

               
                    for (int i = 0; i < num; i++)
                    {
                        string w = ss.ReadLine();

                        if (w.ToUpper() != new string(w.ToUpper().Reverse().ToArray()))
                            ss2.WriteLine("NO");
                        else
                        {
                            ss2.WriteLine("YES");
                        }

                    }
                   
                ss.Close();
                ss2.Close();

        }
    }
}
