using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandelingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            gtDirectoryInfo();
            /*String filePath = @"D:/sample.txt";
           // File.Create(filePath);
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Created Successfully");
                //writing single line in file
                // File.WriteAllText(filePath, "WelCom Chhaya Lets start writing in file");

                //Multiple lines writing
                string[] lines = new string[]
                {
                    "Hii there",
                    "Chhaya Chaudhary",
                    "From Nirvana Solutions",
                    DateTime.Now.ToString()
                };
                //File.WriteAllLines(filePath, lines);

                //Read File
                string[] readlines= File.ReadAllLines(filePath);
                foreach(var line in readlines)
                {
                    Console.WriteLine(line);    
                }

            }
            else
                Console.WriteLine("File not created");

            //CreateDirectory();*/
            Console.ReadKey();

        }

        public static void gtDirectoryInfo()
        {
            string dPath = @"D:/";
            string[] folders=Directory.GetDirectories(dPath);
            string[] files = Directory.GetFiles(dPath);
            FileInfo f1 = new FileInfo(dPath + "/sample.txt");
            Console.WriteLine(f1.FullName);
            Console.WriteLine(f1.Extension);
            Console.WriteLine(f1.Length);
            foreach (string folder in files)
            {
                Console.WriteLine(folder);
            }
        }
        public static void CreateDirectory()
        {
            String dirPath = @"D:/DemoFol/sample";
            Directory.CreateDirectory(dirPath);
            if(Directory.Exists(dirPath))
            {
                Console.WriteLine("Directory Created SuccessFully");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
