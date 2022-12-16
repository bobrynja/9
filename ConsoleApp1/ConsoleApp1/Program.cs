using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество чисел в последовательности: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[n];
                Console.WriteLine("Введите числа: ");
                for (int i = 0; i < n; i++)
                {
                    nums[i] = Convert.ToInt32(Console.ReadLine());
                }
                StreamWriter sw = new StreamWriter("./res.dat");
                for (int i = 0; i < n; i++)
                {
                    if (nums[i] % 2 == 0) sw.WriteLine(nums[i]);
                }
                sw.Close();



                Console.WriteLine("Вывод результата: ");
                StreamReader sr = new StreamReader("./res.dat");
                string line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных!!!");
                Console.ReadKey();
            }








        }
}
    }

