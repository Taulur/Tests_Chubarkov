using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Ploskih_3
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines(args[0]);
                int n = int.Parse(lines[0]); 
                int[] diameters = lines[1].Split(' ').Select(int.Parse).ToArray(); 
                int[,] snowmanPairs = new int[n, 2];
                var indexedDiameters = new (int diameter, int index)[2 * n];
                for (int i = 0; i < 2 * n; i++)
                {
                    indexedDiameters[i] = (diameters[i], i + 1); 
                }
                Array.Sort(indexedDiameters, (x, y) => x.diameter.CompareTo(y.diameter));
                for (int i = 0; i < n; i++)
                {
                    snowmanPairs[i, 0] = indexedDiameters[2 * i + 1].index; 
                    snowmanPairs[i, 1] = indexedDiameters[2 * i].index;     
                }
                using (StreamWriter writer = new StreamWriter(args[1]))
                {
                    for (int i = 0; i < n; i++)
                    {
                        writer.WriteLine($"{snowmanPairs[i, 0]} {snowmanPairs[i, 1]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
