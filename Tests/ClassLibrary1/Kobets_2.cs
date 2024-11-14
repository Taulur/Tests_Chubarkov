using System;
using System.IO;

namespace ClassLibrary1
{
    public class Kobets_2
    {
        public static void Main(string[] args)
        {
            string inputFile = args[0];
            string outputFile = args[1];
            if ((File.Exists(inputFile) && File.Exists(outputFile)))
            {
                string[] fileData = File.ReadAllLines(inputFile);
                Console.WriteLine(args[0]);
                foreach(var s in fileData)
                    Console.WriteLine(s);
                string[] output = new string[fileData.Length - 1];
                int n = int.Parse(fileData[0]);
                if(1 <= n && n <= 20)
                {
                    for(int i = 1; i < fileData.Length; i++)
                    {
                        char[] charArray = fileData[i].ToCharArray();
                        Array.Reverse(charArray);
                        string str = new string(charArray);
                        if (string.Equals(fileData[i], str, StringComparison.CurrentCultureIgnoreCase))
                        {
                            output[i - 1] = "YES";
                        }
                        else
                        {
                            output[i - 1] = "NO";
                        }
                    }
                    StreamWriter sw = File.CreateText(outputFile);
                    Console.WriteLine(args[1]);
                    foreach (var s in output)
                    {
                        Console.WriteLine(s);
                        sw.WriteLine(s);
                    }
                    sw.Close();
                }
            }
        }
    }
}
