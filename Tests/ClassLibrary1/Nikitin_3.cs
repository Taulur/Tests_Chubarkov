using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Nikitin_3
    {
        public static void Main(string[] args)
        {
            StreamReader sr = File.OpenText(args[0]);
            StreamWriter sw = File.CreateText(args[1]);
            int n = int.Parse(sr.ReadLine());
            string[] text = sr.ReadLine().Split(' ');
            sr.Close();
            int[] arr = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = int.Parse(text[i]);
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int number = arr[j];
                        arr[j] = arr[i];
                        arr[i] = number;
                    }
                }
            }
            int[] correct = new int[arr.Length];    
            for (int i = arr.Length - 1; i >= 0; i--) 
            {
                for (int j = 0; j < arr.Length; j++) 
                {
                    if (int.Parse(text[j]) == arr[i]) correct[i] = j + 1;
                }
            }
            for (int i = 0; i < arr.Length; i += 2)
            {
                sw.WriteLine(correct[i + 1] + " " + correct[i]);
            }
            sw.Close();
        }
    }
}
