using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\admin\Desktop\lab-2-zi-chuan-chu-li-hunterze\Data\Input.txt")) 
            {

                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        Console.Write(ch);
                        if(ch=='?')
                        {
                            Console.Write('\n');
                        }
                        if (ch == '.')
                        {
                            Console.Write('\n');
                        }
                        if (ch == '!')
                        {
                            Console.Write('\n');
                        }
                    }
                }
                Console.Read();
            }
        }
    }
}
