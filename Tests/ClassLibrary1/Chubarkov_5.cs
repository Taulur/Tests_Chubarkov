

using System.Collections.Generic;
using System;
using System.IO;

namespace ClassLibrary1
{
    public class Chubarkov_5
    {
        public static void Main(string[] args)
        {
            int n, v, t, k;
            string[] lines = File.ReadAllLines(args[0]);
            n = Convert.ToInt32(lines[0]);
            string[] line = lines[1].Split(' ');
            v = Convert.ToInt32(line[0]);
            t = Convert.ToInt32(line[1]);
           
            k = (v * t) % n;
            File.WriteAllText(args[1], k.ToString());
        }
    }
}
            