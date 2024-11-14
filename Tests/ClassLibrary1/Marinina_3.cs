using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Marinina_3
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            int number = Convert.ToInt32(sr.ReadLine());
            string[] diameter = sr.ReadLine().Split(' ').ToArray();
            sr.Close();
            int[] intmas = new int[diameter.Length];
            for(int i=0;i<diameter.Length;i++)
            {
                intmas[i] = Convert.ToInt32(diameter[i]);
            }
            Array.Sort(intmas);
            intmas = intmas.Reverse().ToArray();
            StreamWriter sw = File.CreateText(args[1]);
            int[] pairs = new int[intmas.Length];
            for (int i=0;i<intmas.Length;i++)
            {
                for(int j = 0;j < diameter.Length;j++)
                {
                    if (intmas[i].ToString() == diameter[j])
                        pairs[i] = j + 1;
                }
            }
            for(int i=0;i<pairs.Length-1;i=i+2)
            {
                string p = $"{pairs[i]} {pairs[i + 1]}";
                sw.WriteLine(p);
            }
            sw.Close();
        }
    }
}
