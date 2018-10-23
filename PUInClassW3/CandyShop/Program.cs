using System;
using System.Text;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Candy for{Бачо Пенка}");


            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\fmi\Desktop\Urumov week-3\PU_IntroCSharp_InClass_1801681067\PUInClassW3\CandyShop\files\students.txt");
            int tStudents = 0;


            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string firstName = elements[1];
                string name = $"{elements[1]} {elements[3]}";

                // Use a tab to indent each line of the file.
                // Console.WriteLine("\t" + line);

                int sum = 0;

                for (int i = 0; i < firstName.Length; i++)
                {

                    sum += (int)firstName[i];
                }

                if (sum > 9000)
                {
                    tStudents += 1;
                    Console.WriteLine($"Candy for{name} => {firstName.Length}");
                }
                    
            }

               

            Console.WriteLine($"TOTAL LINES{lines.Length}");
            Console.WriteLine($"Total candy students:{tStudents}");

        }





        }
    }

