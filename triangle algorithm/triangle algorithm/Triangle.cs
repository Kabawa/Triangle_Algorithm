using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_algorithm
{
    public class Triangle
    {
        public int[,] Elements { get; set; }

        public void ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int size = lines.Length;
            int[,] triangle = new int[size, size];
            try
            {
                string line;
                int lenght = 1;
                int j = 0;

                while (j < size)
                {
                    line = lines[j];
                    string[] massLine = line.Split(new char[] {' '});


                    for (int i = 0; i < lenght; i++)
                    {
                        triangle[j, i] = Int32.Parse(massLine[i]);
                    }
                    lenght++;
                    j++;
                }
                Elements = triangle;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void FindMaxPath(int[,] triangle)
        {
            int size = Convert.ToInt32(Math.Sqrt(Elements.Length));
            for (int i = size - 1; i > 0; i--)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (triangle[i, j] > triangle[i, j + 1])
                    {
                        triangle[i - 1, j] += triangle[i, j];
                    }
                    else
                    {
                        triangle[i - 1, j] += triangle[i, j + 1];
                    }
                }
                size--;
            }
        }
    }
}