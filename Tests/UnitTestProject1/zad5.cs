using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.IO;
using System.Collections.Generic;
using zad5;

namespace zad5
{
 
    class zd_5
    {
        public static string inputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\input.txt"; //меняем на нужный путь
        public static string outputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\output.txt"; //меняем на нужный путь
    }

    [TestClass]
    public class Chubarkov
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Chubarkov_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Marunenko
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Marunenko_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Mezenceva
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Mezenceva_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Nikitin
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Nikitin_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Ploskih
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Ploskih_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Mokeev
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Mokeev_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Romanov
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Romanov_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Rubtsova
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Rubtsova_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Forrat
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Forrat_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
    [TestClass]
    public class Sergeeva
    {
        void Zad5(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            StreamWriter inputWrite = new StreamWriter(zd_5.inputPath);
            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }
            inputWrite.Close();
            Sergeeva_5.Main(new string[] { zd_5.inputPath, zd_5.outputPath });
            StreamReader inputReader = new StreamReader(zd_5.outputPath);
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
        public void Проехал_50_из_100() // 1
        {
            Zad5(new List<string> { "100", "10 5" }, new List<string> { "50" });
        }
        [TestMethod]
        public void Проехал_1_из_100() // 1
        {
            Zad5(new List<string> { "100", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_99_из_100() // 1
        {
            Zad5(new List<string> { "100", "99 1" }, new List<string> { "99" });
        }
        [TestMethod]
        public void Проехал_32_из_32() // 1
        {
            Zad5(new List<string> { "32", "8 4" }, new List<string> { "0" });
        }
        [TestMethod]
        public void Проехал_68_из_32() // 1
        {
            Zad5(new List<string> { "32", "17 4" }, new List<string> { "4" });
        }
        [TestMethod]
        public void Проехал_110_из_20() // 1
        {
            Zad5(new List<string> { "20", "10 11" }, new List<string> { "10" });
        }
        [TestMethod]
        public void Проехал_555_из_1() // 1
        {
            Zad5(new List<string> { "2", "555 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_1_из_555() // 1
        {
            Zad5(new List<string> { "555", "1 1" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_3_из_2() // 1
        {
            Zad5(new List<string> { "2", "1 3" }, new List<string> { "1" });
        }
        [TestMethod]
        public void Проехал_81_из_3() // 1
        {
            Zad5(new List<string> { "3", "9 9" }, new List<string> { "0" });
        }

    }
}
