

using System.IO;
using System;

namespace ClassLibrary1
{
    public class Mezenceva_2
    {
        public static void Main(string[] args)
        {
            string[] str;
            using (var reader = new StreamReader(args[0]))
            {
                str = reader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(str[0]) > 20) return;
            }
            using (var writer = new StreamWriter(args[1]))
            {
                foreach (var item in str)
                {
                    if (item != str[0])
                    {
                        char[] chMas = item.ToUpper().ToCharArray();
                        bool isPalindrome = true;

                        for (int i = 0; i < chMas.Length / 2; i++)
                        {
                            if (chMas[i] != chMas[chMas.Length - 1 - i])
                            {
                                isPalindrome = false;
                                break;
                            }
                        }

                        if (isPalindrome)
                        {
                            writer.WriteLine("YES");
                        }
                        else
                        {
                            writer.WriteLine("NO");
                        }
                    }
                }
            }
        }
    }
}

