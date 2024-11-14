using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Nikitin_5
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            StreamWriter sw = File.CreateText(args[1]);
            int n = int.Parse(sr.ReadLine());
            string[] date = sr.ReadLine().Split(' ');
            int v = int.Parse(date[0]);
            int t = int.Parse(date[1]);
            int s = (v * t) % n;
            sw.WriteLine(s);
            sr.Close();
            sw.Close();

        }
    }
}
