using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = "C:/Users/lenovo/Desktop/PP2/Week2/Task 4/Create/Askar.txt";
            string fileName = "Askar.txt";
            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }
            string destFile = "C:/Users/Lenovo/Desktop/PP2/Week2/Task 4/Copy/Askar.txt";
            string sourceFile = "C:/Users/Lenovo/Desktop/PP2/Week2/Task 4/Create/Askar.txt";
            System.IO.File.Copy(sourceFile, destFile, true);
            if (System.IO.File.Exists("C:/Users/Lenovo/Desktop/PP2/Week2/Task 4/Create/Askar.txt"))
            {

                try
                {
                    System.IO.File.Delete("C:/Users/Lenovo/Desktop/PP2/Week2/Task 4/Create/Askar.txt");
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

        }
    }
}