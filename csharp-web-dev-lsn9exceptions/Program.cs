using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            double answer = x / y;
            try
            {                
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot divide by zero");
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                answer = 0;
                Console.WriteLine(e.Message);
            }
            return answer;
        }


        static int CheckFileExtension(string fileName)
        {
            int points;
            if (fileName.EndsWith(".cs"))
            {
                points = 1;
            }
            else points = 0;
            try
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    throw new FormatException("File name must not be null or empty");
                }
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            return points;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            Console.WriteLine(Divide(10, 0));
            Console.WriteLine(Divide(10, 3));


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> a in students)
            {
                Console.WriteLine(CheckFileExtension(a.Value));
            }


        }
    }
}
