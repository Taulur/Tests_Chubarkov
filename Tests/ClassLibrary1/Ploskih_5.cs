using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary1
{
    public class Ploskih_5
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
            int n = Convert.ToInt32(lines[0]);
            string[] par = lines[1].Split(' ');
            int v = Convert.ToInt32(par[0]);
            int t = Convert.ToInt32(par[1]);
            int k = (v * t) % n;
            File.WriteAllText(args[1], k.ToString());
        }
    }
}
