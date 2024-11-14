using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Forrat_3
    {
        public static void Main(string[] args)
        {
            string[] inputLines = File.ReadAllLines(args[0]);
            int n = int.Parse(inputLines[0]);
            int[] diameters = inputLines[1].Split(' ').Select(int.Parse).ToArray();
            var indexedDiameters = diameters
                .Select((d, i) => (Diameter: d, Index: i + 1))
                .OrderBy(x => x.Diameter)
                .ToList();
            List<(int, int)> snowmen = new List<(int, int)>();
            for (int i = 0; i < n; i++)
            {
                var upper = indexedDiameters[2 * i];
                var lower = indexedDiameters[2 * i + 1];
                snowmen.Add((lower.Index, upper.Index));
            }

            using (StreamWriter writer = new StreamWriter(args[1]))
            {
                foreach (var (lower, upper) in snowmen)
                {
                    writer.WriteLine($"{lower} {upper}");
                }
            }
        }
    }
}
