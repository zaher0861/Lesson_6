using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] s1Array = s1.Split();
            int length = 0;
            string longest = "";
            foreach (string s in s1Array)
            {
                if (s.Length>length)
                {
                    length = s.Length;
                    longest = s;
                }
            }
            Console.WriteLine("Самое длинное слово - {0}, его длина - {1}", longest, length);
            Console.ReadKey();
        }
    }
}
