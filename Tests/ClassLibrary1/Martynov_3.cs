using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Martynov_3
    {
        public static void Main(string[] args)
        {
            string file = args[0];
            string file2 = args[1];

            int temp;
            StreamReader ss = new StreamReader(file);

            int num = int.Parse(ss.ReadLine());

            
            string[] inp = ss.ReadToEnd().Split(' ');

            int[] indexs = new int[inp.Length];

            for (int i=0;i<inp.Length;i++)
            {
                indexs[i] = i+1;

            }

            for (int i=0;i<inp.Length;i++)
            {

                for (int j = 0; j < inp.Length-1-i; j++)
                {
                    if ( int.Parse(inp[j])<int.Parse(inp[j+1])   )
                    {
                        string temp2 = inp[j];
                        inp[j] = inp[j + 1];
                        inp[j + 1] = temp2;



                        temp = indexs[j];
                        indexs[j]= indexs[j+1];
                        indexs[j + 1] = temp;

                    }

                }
            }
            StreamWriter ss2 = new StreamWriter(file2);
            for (int i=0;i<indexs.Length-1;i+=2)
            {
                string s = $"{indexs[i]} {indexs[i+1]}";
                ss2.WriteLine(s);

            }
            ss2.Close();
            ss.Close();


            
        }
    }
}
