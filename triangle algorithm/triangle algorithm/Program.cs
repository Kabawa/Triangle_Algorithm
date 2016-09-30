using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace triangle_algorithm
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Name of files: triangle_1.txt and triangle_2.txt \nPlease write name of file");
            string filePath = Console.ReadLine();
            while (!File.Exists(filePath))
            {
                Console.WriteLine("Invalid name of file. Please try again!");
                filePath = Console.ReadLine();
            }
      
            Triangle tr = new Triangle();
            tr.ReadFile(filePath);

            tr.FindMaxPath(tr.Elements);

            Console.WriteLine("\nthe maximum path is " + tr.Elements[0,0]);
            Console.ReadLine();
        }
    }

}
