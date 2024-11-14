using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace ClassLibrary1
{
    public class Marunenko_5
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(args[0]);
            StreamWriter sw = new StreamWriter(args[1]);
            int N = int.Parse(sr.ReadLine());
            string[] input = sr.ReadLine().Split();
            int v = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            int dist = v * t;
            int k = dist % N;
            sw.WriteLine(k);
            sr.Close();
            sw.Close();
        }
    }
}
