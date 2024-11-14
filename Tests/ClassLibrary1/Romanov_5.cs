using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassLibrary1
{
    public class Romanov_5
    {

        public static void Main(string[] args)
        {
            //circule race
            int S=0, V=0, t = 0;
            string[] line = File.ReadAllLines(args[0]);
            S = int.Parse(line[0]);
            t = int.Parse(line[1].Substring(line[1].LastIndexOf(' ')));
            V = int.Parse(line[1].Substring(0,line[1].LastIndexOf(' ')));
           

            StreamWriter sw = new StreamWriter(args[1]);
            
            int K = (V * t);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Car stopped before {K} km");
            Console.ResetColor();
            sw.WriteLine(K);
            sw.Close();

        }
    }
}
