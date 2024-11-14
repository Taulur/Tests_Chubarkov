using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Azarenko_2
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            int num=int.Parse(sr.ReadLine());
            if(num>0 && num <=20)
            {
                StreamWriter sw = File.CreateText(args[1]);
                for(int i=0;i<num;i++)
                {
                    string p=sr.ReadLine();
                    if(p.ToUpper()==new string(p.Reverse().ToArray()).ToUpper())
                    {
                        sw.WriteLine("YES");
                    }
                    else
                    {
                        sw.WriteLine("NO");
                    }
                }
                
                sw.Close();
            }
            else 
            { 
                Console.WriteLine("Значение n введено неверно");
            }
            sr.Close();
        }
    }
}
