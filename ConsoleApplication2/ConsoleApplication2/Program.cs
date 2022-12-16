using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("./res.txt");
                string line = sr.ReadLine();
                string result = line;
                int n = line.Length;
                while (line != null)
                {
                    if (line.Length > n)
                    {
                        result = line;
                        n = line.Length;
                    }
                    line = sr.ReadLine();
                }
                Console.WriteLine("Самая длинная строка:");
                Console.WriteLine(result);
                Console.WriteLine("Её длина равна " + n);
                sr.Close();
            }
            catch { Console.WriteLine("Файл не найден!!!"); }
            Console.ReadLine();
        }
    }
    }

