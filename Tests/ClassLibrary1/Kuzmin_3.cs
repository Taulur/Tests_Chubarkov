using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Kuzmin_3
    {
        public static void Main(string[] args)
        {
            StreamReader a = File.OpenText(args[0]);
            StreamWriter b = File.CreateText(args[1]);
            int f = int.Parse(a.ReadLine());
            
            string[] d = a.ReadLine().Split(new char[] { ' ' });
            string[] d1 = new string[d.Length];
            d.CopyTo(d1, 0);
            a.Close();


            for (int j = 0; j < d.Length; j++)
            {
                for (int i = 0; i < d.Length-1 ; i++)
                {
                    if (int.Parse(d[i]) < int.Parse(d[i + 1]))
                    {
                        (d[i], d[i + 1]) = (d[i + 1], d[i]);
                    }
                }

            }
            for (int j = 0; j < d.Length-1; j++)
            {
                for(int i=0;i<f;i++)
                {
                    if (!(f - i == 1))
                    {
                        b.Write(Array.IndexOf(d1,d[j+i])+1 + " ");
                    }
                    else
                    {
                        b.WriteLine(Array.IndexOf(d1, d[j + i])+1);
                        j++;
                    }
                }
                
            }
            
            b.Close();
        }
    }
}
