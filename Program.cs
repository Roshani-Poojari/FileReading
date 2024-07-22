using System.IO;

namespace FileHandlingReadDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\Users\roshani.poojari\Desktop\Training\FileHandlingReadDemo\assets\ReadFile.txt";
            string file2 = @"C:\Users\roshani.poojari\Desktop\Training\FileHandlingReadDemo\assets\Trial.html";

            Console.WriteLine("Reading Txt File");
            if (File.Exists(file1))
            {
                using (StreamReader sr = new StreamReader(file1))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            else
                Console.WriteLine("File does not exist");
            Console.WriteLine("Reading Html File");
            if (File.Exists(file2))
            {
                using (StreamReader sr = new StreamReader(file2))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            else
                Console.WriteLine("File does not exist");
        }
    }
}


