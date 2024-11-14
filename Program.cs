using System;
using System.IO;
using System.Linq.Expressions;
using System.Xml;

namespace CCAD16_Assignment2_3_1_SR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile(@"Test.txt");
            ReadFile(@"Test.txt");
        }

        static public void ReadFile(string path)
        {
            string filePath = @"Test.txt";
            string line;
            StreamReader sr = new StreamReader(filePath);
            line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();             
        }

        static public void WriteFile(string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("Hello World");
            sw.WriteLine("This is an additional line.");
            sw.Close();
        }
    }
}