using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Sergeeva_5
    {
        public static void Main(string[] args)
        {
            string inputFile = args[0];
            string outputFile = args[1];

            string[] parts = File.ReadAllLines(inputFile);
            int N = int.Parse(parts[0]); 
            string[] driver = parts[1].Split(' ');
            int V = int.Parse(driver[0]);
            int t = int.Parse(driver[1]);

            Console.WriteLine($"Кол-во кругов: {N}\nСкорость автомобиля:{V}\nВремя: {t}\n");

            int K = 0;
            int s = V * t;
            if (s < N) K = s;
            else if (s == N) K = 0;
            else
            {
                K = -(N - s);
            }

            Console.WriteLine(K);
            File.WriteAllText(outputFile, K.ToString());
        }
    }
}