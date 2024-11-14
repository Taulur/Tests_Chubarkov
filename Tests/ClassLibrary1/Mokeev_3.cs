using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mokeev_3
    {
        public static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);
            int n = int.Parse(lines[0]);
            int[] unsorted = lines[1].Split(' ').Select(int.Parse).ToArray();
            var indexedDiameters = unsorted.Select((d, i) => (Diameter: d, Index: i + 1)).ToArray();
            Array.Sort(indexedDiameters, (a, b) => a.Diameter.CompareTo(b.Diameter));
            string[] output = new string[n];
            int size = indexedDiameters.Length-1;
            int ii = 0;
            for (int i = 0; i < size; i+=2)
            {
                int lowerIndex = indexedDiameters[size-i].Index;
                int upperIndex = indexedDiameters[size-i-1].Index;
                output[ii] = $"{lowerIndex} {upperIndex}";
                ii++;
            }
            File.WriteAllLines(args[1], output);
        }
    }
}
