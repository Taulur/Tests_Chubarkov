using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Azarenko_3
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            int num = int.Parse(sr.ReadLine());
            string[] diam =sr.ReadLine().Split(' ').ToArray();
                sr.Close();
            int[] id = new int[diam.Length];
            for (int i=0;i<diam.Length;i++)
            {
                id[i] = int.Parse(diam[i]);
            }
            Array.Sort(id);
            id = id.Reverse().ToArray();
            StreamWriter sw = File.CreateText(args[1]);
            int[] pairs = new int[id.Length];
            for(int i=0;i<id.Length;i++)
            {
                for(int j=0;j<diam.Length;j++)
                {
                    if (id[i].ToString() == diam[j])
                        pairs[i] = j+1;
                  
                }
            }
            for (int i = 0; i < pairs.Length - 1; i = i+2)
            {
                string l=$"{pairs[i]} {pairs[i + 1]}";
                sw.WriteLine(l);
            }
            sw.Close();
        }
    }
}
