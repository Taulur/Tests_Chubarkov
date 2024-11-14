using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rubtsova_5
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(args[0]);
            int N = int.Parse(input[0]); 
            string[] parameters = input[1].Split(' ');
            int V = int.Parse(parameters[0]); 
            int t = int.Parse(parameters[1]); 
            int distance = V * t;
            int K = distance % N;
            File.WriteAllText(args[1], K.ToString());
        }
    }
}
