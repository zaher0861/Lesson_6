using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] s1Array = s1.Split();
            string s2 = "";
            int n;
            foreach (string s in s1Array)
            {
                s2 += s;
            }
            n = s2.Length;
            for (int i = 0; i < n; i++)
            {
                if (s2[i] == s2[n-1-i])
                {
                    if (i == n-1)
                    {
                        Console.WriteLine("Ваше предложение - палиндром! Поздравяю!");
                    }
                }
                else
                {
                    Console.WriteLine("Ваше предложение не является палиндромом!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
