using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Kuzmin_2
    {
        public static void Main(string[] args)
        {
            StreamReader a = File.OpenText(args[0]);
            StreamWriter b = File.CreateText(args[1]);
            int h =int.Parse( a.ReadLine());

            for (int i=0;i<h;i++)
            { 
                string h1 = a.ReadLine();
                string k = "";
                string k1 = "";
            for(int j=0; j<h1.Length;j++)
            {
                    k += Char.ToUpper(h1[j]);
            }
                for (int j = h1.Length-1; j >= 0; j--)
                {
                    k1 += Char.ToUpper(h1[j]);
                }
                if(k==k1)
                {
                    b.WriteLine("YES");
                }
                else
                    b.WriteLine("NO");

            }
            a.Close();
            b.Close();
        }
    }
}
