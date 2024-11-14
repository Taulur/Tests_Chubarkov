using System;
using System.IO;

namespace ClassLibrary1
{
    public class Chubarkov_2
    {
        public static void Main(string[] args)
        {
            int k, n;

            string[] lines = File.ReadAllLines(args[0]);
            n = Convert.ToInt32(lines[0]);
            StreamWriter writer = File.CreateText(args[1]);
            for (int i = 1; i < n + 1; i++)
            {
                string reversed = null;
                for (int j = lines[i].Length - 1; j > -1; j--)
                {
                    reversed += lines[i][j];
                }
                if (reversed.ToLower() == lines[i].ToLower())
                {

                    writer.WriteLineAsync("YES");

                }
                else
                {

                    writer.WriteLineAsync("NO");

                }

            }

            writer.Close();
        }
    }
}
           