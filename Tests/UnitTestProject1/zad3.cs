using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.IO;
using System.Collections.Generic;
using zad2;

namespace zad3
{
 
    class zd_3
    {
        public static string inputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\input.txt"; //меняем на нужный путь
        public static string outputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\output.txt"; //меняем на нужный путь
    }

    [TestClass]
    public class Chubarkov
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Chubarkov_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> {"1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Ploskih
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Ploskih_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Nikitin
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Nikitin_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Mokeev
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Mokeev_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Romanov
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Romanov_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Rubtsova
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Rubtsova_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Forrat
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Forrat_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Azarenko
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Azarenko_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Gorelova
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Gorelova_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Kobets
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Kobets_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Marinina
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Marinina_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Martynov
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Martynov_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Kuzmin
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Kuzmin_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
    [TestClass]
    public class Lezhen
    {
        void Zad3(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Lezhen_3.Main(new string[] { zd_3.inputPath, zd_3.outputPath });
            StreamReader inputReader = new StreamReader(zd_2.outputPath);
            while (!inputReader.EndOfStream)
            {
                result.Add(inputReader.ReadLine());
            }
            inputReader.Close();
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
        [TestMethod]
        public void Пять_пар() // 1
        {
            Zad3(new List<string> { "5", "70 12 65 35 110 63 22 10 43 39" }, new List<string> { "5 1", "3 6", "9 10", "4 7", "2 8" });
        }
        [TestMethod]
        public void Минимальное_количество_пар() // 2
        {
            Zad3(new List<string> { "1", "98 97" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_с_большими_диаметрами() // 3
        {
            Zad3(new List<string> { "2", "70 12 55 32" }, new List<string> { "1 3", "4 2" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_диаметрами() // 4
        {
            Zad3(new List<string> { "2", "15 12 10 7" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_с_маленькими_и_большими_диаметрами() // 5
        {
            Zad3(new List<string> { "2", "120 12 10 89" }, new List<string> { "1 4", "2 3" });
        }
        [TestMethod]
        public void Три_пары_с_большими_диаметрами() // 6
        {
            Zad3(new List<string> { "3", "70 12 55 32 10 95" }, new List<string> { "6 1", "3 4", "2 5" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_диаметрами() // 7
        {
            Zad3(new List<string> { "3", "18 5 10 4 21 6" }, new List<string> { "5 1", "3 6", "2 4" });
        }
        [TestMethod]
        public void Три_пары_с_маленькими_и_большими_диаметрами() // 8
        {
            Zad3(new List<string> { "3", "45 9 10 89 23 112" }, new List<string> { "6 4", "1 5", "3 2" });
        }
        [TestMethod]
        public void Одна_пара_с_конца() // 9
        {
            Zad3(new List<string> { "1", "6 112" }, new List<string> { "2 1" });
        }
        [TestMethod]
        public void Одна_пара_с_начала() // 10
        {
            Zad3(new List<string> { "1", "100 2" }, new List<string> { "1 2" });
        }
        [TestMethod]
        public void Две_пары_по_порядку() // 11
        {
            Zad3(new List<string> { "2", "4 3 2 1" }, new List<string> { "1 2", "3 4" });
        }
        [TestMethod]
        public void Две_пары_в_обратном_порядке() // 12
        {
            Zad3(new List<string> { "2", "1 2 3 4" }, new List<string> { "4 3", "2 1" });
        }
        [TestMethod]
        public void Три_пары_по_порядку() // 13
        {
            Zad3(new List<string> { "3", "6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6" });
        }
        [TestMethod]
        public void Три_пары_в_обратном_порядке() // 14
        {
            Zad3(new List<string> { "3", "1 2 3 4 5 6" }, new List<string> { "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары() // 15
        {
            Zad3(new List<string> { "4", "7 54 12 35 73 22 10 99" }, new List<string> { "8 5", "2 4", "6 3", "7 1" });
        }
        [TestMethod]
        public void Четыре_пары_по_порядку() // 16
        {
            Zad3(new List<string> { "4", "8 7 6 5 4 3 2 1" }, new List<string> { "1 2", "3 4", "5 6", "7 8" });
        }
        [TestMethod]
        public void Четыре_пары_в_обратном_порядке() // 17
        {
            Zad3(new List<string> { "4", "1 2 3 4 5 6 7 8" }, new List<string> { "8 7", "6 5", "4 3", "2 1" });
        }
        [TestMethod]
        public void Четыре_пары_половина_по_порядку_половина_наоборот() // 18
        {
            Zad3(new List<string> { "4", "1 2 3 4 8 7 6 5" }, new List<string> { "5 6", "7 8", "4 3", "2 1" });
        }
        [TestMethod]
        public void Большие_диаметры() // 19
        {
            Zad3(new List<string> { "2", "634 1021 323 899" }, new List<string> { "2 4", "1 3" });
        }
        [TestMethod]
        public void Маленькие_диаметры() // 20
        {
            Zad3(new List<string> { "2", "2 4 5 3" }, new List<string> { "3 2", "4 1" });
        }
    }
}
