using System;
using System.IO;
using System.Collections.Generic;

namespace ClassLibrary1
{
    struct Par
    {
        public int top;
        public int down;
    }
    public class Kobets_3
    {
        public static void Main(string[] args)
        {

            if ((File.Exists(args[0]) && File.Exists(args[1])))
            {
                string[] fileData = File.ReadAllLines(args[0]);
                if (1 <= int.Parse(fileData[0]) && int.Parse(fileData[0]) <= 30000)
                {
                    Console.WriteLine(args[0]);
                    int n = int.Parse(fileData[0]);
                    Console.WriteLine(n.ToString());
                    List<string> arr = new List<string>();
                    foreach (var s in fileData[1].Split(' '))
                    {
                        arr.Add(s);
                        Console.Write(s + " ");
                    }
                    List<Par> pars = new List<Par>();
                    for(int i = 0; i < arr.Count; i++)
                    {
                        for(int j = 0; j < arr.Count; j++)
                        {
                            if(arr[i] != "" && arr[j] != "")
                            if(Convert.ToInt32(arr[i]) > Convert.ToInt32(arr[j]))
                            {
                                Par par = new Par();
                                par.top = i + 1;
                                par.down = j + 1;
                                pars.Add(par);
                                arr[i] = "";
                                arr[j] = "";
                                
                            }
                        }
                    }

                    StreamWriter sw = File.CreateText(args[1]);
                    Console.WriteLine(args[1]);
                    for(int i = 0; i < pars.Count; i++)
                    {
                        sw.WriteLine($"{pars[i].top} {pars[i].down}");
                        Console.WriteLine($"{pars[i].top} {pars[i].down}");
                    }
                    sw.Close();
                    
                }
            }
        }
    }
}
