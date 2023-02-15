﻿using System.IO;
using System;
using System.Text;

namespace Potoki.Streams
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var sw = new StreamWriter(@"D:\Разработка\C#\Potoki.Streams\test.txt", true, Encoding.UTF8))      //путь, перезапись, кодировка
            {
                sw.Write("Hello, World!");
                sw.WriteLine("Новая строка");
            }

            using (var sr = new StreamReader(@"D:\Разработка\C#\Potoki.Streams\test.txt", Encoding.UTF8))
            {
                var text = sr.ReadToEnd();                                                                                //читает весь файл и записывает в переменную
                Console.Write(text);
            }
        }
    }
}