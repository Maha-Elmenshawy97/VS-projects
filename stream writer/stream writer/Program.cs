using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stream_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of lines:");
            int n =int.Parse(Console.ReadLine());
            string[] text = new string[n];
            Console.WriteLine("write the text......");
            for (int i = 0; i < n; i++)
            {
                text[i] = Console.ReadLine();
            }
            StreamWriter word = new StreamWriter(@"text.txt");
            for (int i = 0; i < n; i++)
            {
                word.WriteLine(text[i]);
            }
            word.Close();
        }
    }
}
