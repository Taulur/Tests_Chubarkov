using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gorelova_3
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            int num=int.Parse(sr.ReadLine());
            string[] a = sr.ReadLine().Split(' ').ToArray();
            sr.Close();
            int[]b = new int[a.Length];
            for(int i=0;i<a.Length; i++)
            {
                b[i]=int.Parse(a[i]);
            }
            Array.Sort(b);
            b=b.Reverse().ToArray();
            StreamWriter sw = File.CreateText(args[1]);
            int[]d= new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j=0; j < a.Length; j++)
                {
                    if (b[i].ToString() == a[j])
                        d[i] = j + 1;
                }
            }
            for (int i = 0; i < d.Length-1; i=i+2)
            {
                sw.WriteLine($"{d[i]} {d[i+1]}");
            }
            sw.Close();
        }
    }
}
