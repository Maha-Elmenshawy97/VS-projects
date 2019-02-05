using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_operation
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("please enter the file name.....");
            string file =Console.ReadLine();
           
                Console.WriteLine("please enter the operation.....");
                string op = Console.ReadLine();
                switch (op)
                {
                    case "creat": File.Create(file); break;
                    case "delete": delete(file); break;
                    case "rename": rename(file); break;
                    case "info": information(file); break;
                    default: Console.WriteLine("wrong operation"); break;
                }
          
            Console.ReadKey();
        }
        public static void delete(string f)
        {
            
            if (File.Exists(f))
            {
                File.Delete(f);
                if (File.Exists(f) == false)
                {
                    Console.WriteLine("file {0} delete from the directory", f);
                }
            }
            else Console.WriteLine("we didi not found your file {0}", f);
        }
        public static void rename(string f)
        {
            Console.WriteLine("please enter the new name.....");
            string new_name = Console.ReadLine();
            if (File.Exists(f) && new_name != string.Empty)
            {
                File.Move(f, new_name);
                if (File.Exists(new_name))
                {
                    Console.WriteLine("you have change the file name to {0}", new_name);
                }
            }
            else Console.WriteLine("we didi not found your file {0}", f);
        }
        public static void information(string f)
        {
            FileInfo fi = new FileInfo(f);
            if (fi != null)
            {
                Console.WriteLine("-----file ID-----");
                Console.WriteLine("file:{0}",fi.Name);
                Console.WriteLine("size:{0} bytes",fi.Length);
                Console.WriteLine("last modified {0}",fi.LastWriteTime);
                Console.WriteLine("creation time {0}",fi.CreationTime);
                Console.WriteLine("Directory {0}",fi.Directory);
                Console.WriteLine("full path {0}",fi.FullName);
                Console.WriteLine("extesion is {0}",fi.Extension);
                Console.WriteLine("-----content-----");
                Console.WriteLine(File.ReadAllText(f));
            }
        }
    }
}
