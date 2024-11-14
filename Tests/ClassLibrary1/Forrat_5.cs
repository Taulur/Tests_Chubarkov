using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Forrat_5
    {
       public static void Main(string[] args)
        {

            string[] inputLines = File.ReadAllLines(args[0]);
            int N = int.Parse(inputLines[0]); 
            string[] parameters = inputLines[1].Split(' ');
            int V = int.Parse(parameters[0]); 
            int t = int.Parse(parameters[1]); 

            int distance = V * t;

            int K = distance % N;
            File.WriteAllText(args[1], K.ToString());
        }
    }
}
