

using System.IO;
using System;

namespace ClassLibrary1
{
    public class Mezenceva_5
    {
        public static void Main(string[] args)
        {
            string[] str;
            using (var reader = new StreamReader(args[0]))
            {
                str = reader.ReadToEnd().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            }

            using (var writer = new StreamWriter(args[1]))
            {

                var par = str[1].Split(' ');
                int N = int.Parse(str[0]);
                int V = int.Parse(par[0]);
                int t = int.Parse(par[1]);

                int length = V * t;
                int K = length % N;

                writer.WriteLine(K.ToString());
            }
        }
    }
}