using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.IO;
using System.Collections.Generic;

namespace zad2
{
 
    class zd_2
    {
        public static string inputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\input.txt"; //меняем на нужный путь
        public static string outputPath = @"D:\Projects\ClassLibrary1\ClassLibrary1\bin\Debug\output.txt"; //меняем на нужный путь
    }

    [TestClass]
    public class Chubarkov
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            // Подготовка входных данных

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();


            Chubarkov_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Ploskih
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();


            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();


            Ploskih_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });



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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }



    }
    [TestClass]
    public class Zelina
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            // Подготовка входных данных

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();

            // Запуск программы
            Zelina_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });

            // Проверка результата

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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }

    }
    [TestClass]
    public class Marunenko
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            // Подготовка входных данных

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();

            // Запуск программы
            Marunenko_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });

            // Проверка результата

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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }



    }
    [TestClass]
    public class Mezenceva
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();
            // Подготовка входных данных

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();

            // Запуск программы
            Mezenceva_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });

            // Проверка результата

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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Mokeev
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Mokeev_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Romanov
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Romanov_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }



    }
    [TestClass]
    public class Rubtsova
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Rubtsova_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Forrat
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Forrat_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Azarenko
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Azarenko_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Gorelova
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Gorelova_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Kobets
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Kobets_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Marinina
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Marinina_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Martynov
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Martynov_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Kuzmin
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Kuzmin_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Lezhen
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Lezhen_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }
    }
    [TestClass]
    public class Sergeeva
    {
        void Zad2(List<string> input, List<string> expected)
        {
            List<string> result = new List<string>();

            StreamWriter inputWrite = new StreamWriter(zd_2.inputPath);

            foreach (string line in input)
            {
                inputWrite.WriteLine(line);
            }

            inputWrite.Close();
            Sergeeva_2.Main(new string[] { zd_2.inputPath, zd_2.outputPath });


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
        public void Маленькие_Буквы_Все_Палендром() // 1
        {
            Zad2(new List<string> { "5", "aba", "bcb", "арара", "tyt", "rolor" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Все_Палендром() // 2
        {
            Zad2(new List<string> { "5", "ABA", "BCB", "APAPA", "TYT", "ROLOR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Все_Палендром() // 3
        {
            Zad2(new List<string> { "5", "AbA", "bCB", "ApAPa", "TyT", "RoLoR" }, new List<string> { "YES", "YES", "YES", "YES", "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Почти_Все_Палидром() // 4
        {
            Zad2(new List<string> { "3", "aaa", "bbb", "eqc" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Почти_Все_Палидром() // 5
        {
            Zad2(new List<string> { "3", "AAA", "BBB", "EQC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Почти_Все_Палидром() // 6
        {
            Zad2(new List<string> { "3", "Aaa", "BbB", "eqC" }, new List<string> { "YES", "YES", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Нету_Палидромов() // 7
        {
            Zad2(new List<string> { "3", "aab", "eqb", "tta" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Нету_Палидромов() // 8
        {
            Zad2(new List<string> { "3", "AAB", "EQB", "TTA" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Нету_Палидромов() // 9
        {
            Zad2(new List<string> { "3", "aaB", "eQB", "TTa" }, new List<string> { "NO", "NO", "NO" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Палиндром_Через_Раз() // 10
        {
            Zad2(new List<string> { "5", "aba", "cqe", "tyt", "uio", "ooo" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Палиндром_Через_Раз() // 11
        {
            Zad2(new List<string> { "5", "ABA", "CQE", "TYT", "UIO", "OOO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Палиндром_Через_Раз() // 12
        {
            Zad2(new List<string> { "5", "aBA", "cQe", "TYt", "uio", "OoO" }, new List<string> { "YES", "NO", "YES", "NO", "YES" });
        }
        [TestMethod]
        public void Проверка_На_Единственный_Палиндром() // 13
        {
            Zad2(new List<string> { "1", "aAa", "BBB", "CcC" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Палидром() // 14
        {
            Zad2(new List<string> { "1", "saippuakivikauppias" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Палидром() // 15
        {
            Zad2(new List<string> { "1", "SAIPPUAKIVIKAUPPIAS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Палидром() // 16
        {
            Zad2(new List<string> { "1", "sAipPuakIvikaUpPiaS" }, new List<string> { "YES" });
        }
        [TestMethod]
        public void Маленькие_Буквы_Длинный_Не_Палидром() // 17
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgreurgeugerihgriuguihguuerugeurghuirgiuheihugihruge" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Большие_Буквы_Длинный_Не_Палидром() // 18
        {
            Zad2(new List<string> { "1", "EGIOERGOJIERGJIOEJGIOERJIGRGREURGEUGERIHGRIUGUIHGUUERUGEURGHUIRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Разные_Буквы_Длинный_Не_Палидром() // 19
        {
            Zad2(new List<string> { "1", "egioergojiergjioejgioerjigrgREUrgeugerihgrIUGUIHguUerugeurghuiRGIUHEIHUGIHRUGE" }, new List<string> { "NO" });
        }
        [TestMethod]
        public void Проверка_На_Нуль() // 20
        {
            Zad2(new List<string> { "0", "AAA", "BBB", "CCC" }, new List<string> { });
        }



    }
}
