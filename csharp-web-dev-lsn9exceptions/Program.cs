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
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot divide by zero");
                }
            return answer;
        }


        static int CheckFileExtension(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new FormatException("File name must not be null or empty");
            }
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(10.0, 0.0);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> a in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(a.Value));
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}
