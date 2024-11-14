

using System.Collections.Generic;
using System;
using System.IO;

namespace ClassLibrary1
{
    public class Chubarkov_3
    {
        public static void Main(string[] args)
        {
            int n;
            string[] lines = File.ReadAllLines(args[0]);
            n = Convert.ToInt32(lines[0]);
            string[] line = lines[1].Split(' ');


            List<int> list = new List<int>();
            List<int> sorted = new List<int>();

          


           

            for (int i = 0; i < n*2; i++)
            {
                list.Add(Convert.ToInt32(line[i]));
                sorted.Add(Convert.ToInt32(line[i]));
            }

            sorted.Sort();
            sorted.Reverse();



            StreamWriter writer = File.CreateText(args[1]);

            for (int i = 0; i < sorted.Count; i += 2)
            {
                int first = sorted[i];
                int second = sorted[i + 1];
                int firstpos = 0;
                int secondpos = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (first == list[j])
                    {
                        firstpos = j + 1;
                    }
                    if (second == list[j])
                    {
                        secondpos = j + 1;
                    }
                }
                writer.WriteLine($"{firstpos} {secondpos}");

            }


            writer.Close();
        }
    }
}
            