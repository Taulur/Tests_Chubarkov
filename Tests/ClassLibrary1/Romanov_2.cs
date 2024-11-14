using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Romanov_2
    {
        public static void Main(string[] args)
        {
            //palindrom
            int lineCount = 0;
            string[] line = File.ReadAllLines(args[0]);
            lineCount = int.Parse(line[0]);

            StreamWriter sw = new StreamWriter(args[1]);

            for (int i = 0; i < lineCount; i++)
            {
                if (Prowerka(line[i])||i==0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("YES");
                    sw.WriteLine("YES");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("NO");
                    sw.WriteLine("NO");
                    Console.ResetColor();
                }
            }
            sw.Close();

        }

        private static bool Prowerka(string word)
        { 
            // Проверяем, что слово написано в верхнем регистре
            if (!word.Equals(word.ToUpper()))
            {
                return false;
            }
            // Проверяем, является ли слово палиндромом
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return word.Equals(new string(charArray));
        }
    }
}
