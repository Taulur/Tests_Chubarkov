using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sergeeva_2
    {
        public static void Main(string[] args)
        {

            string inputFile = args[0];
            string outputFile = args[1];

            string[] parts = File.ReadAllLines(inputFile);
            Console.WriteLine($"Кол-во слов: {parts[0]}\n");

            int n = int.Parse(parts[0]);

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(parts[i]);
                    string word = parts[i];
                    string wordUp = word.ToUpper();
                    string newWord = Perevorot(wordUp);
                    if (newWord == wordUp)
                    {
                        writer.WriteLine("YES");
                        Console.WriteLine("YES\n");
                    }
                    else
                    {
                        writer.WriteLine("NO");
                        Console.WriteLine("NO\n");
                    }
                }
            }
        }


        static string Perevorot(string wordUp)
        {
            char[] charWord = wordUp.ToCharArray();
            Array.Reverse(charWord);
            string newWord = "";
            for (int i = 0; i < charWord.Length; i++)
            {
                newWord += charWord[i];
            }

            return newWord;
        }
    }
}
