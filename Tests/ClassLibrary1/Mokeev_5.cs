using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mokeev_5
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]); 
            int n = int.Parse(lines[0]);
            string[] part = lines[1].Split(new char[] { ' ' });
            int v = int.Parse(part[0]);
            int t = int.Parse(part[1]);
            string output = (n-(int)(v*t)).ToString();
            File.WriteAllText(args[1], output);
        }
    }
}
