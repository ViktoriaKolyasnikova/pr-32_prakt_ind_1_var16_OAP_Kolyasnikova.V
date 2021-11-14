using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt");
            string o;
            Console.WriteLine("Содержимое тестового файла:");
            while (sr.EndOfStream != true)
            {
                o = sr.ReadLine();
                Console.WriteLine(o);
            }

            Console.WriteLine();

            var t = File.ReadAllLines("t.txt");
            Console.WriteLine("Символы в обратном порядке:");
            foreach (var r in t)
            {
                Stack s = new Stack();
                foreach (var n in r)
                {
                    s.Push(n);
                }
                var c = s.Count;
                
                for (var i = 0; i < c; i++)
                {
                    Console.Write(s.Pop());
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
