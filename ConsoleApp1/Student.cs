using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        static void Main()
        {
            string StudentName, SchoolName;
            int Age;
            Console.WriteLine("Enter the StudentName");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter the SchoolName");
            SchoolName = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Location");
            string Location=Console.Readline();

            Console.WriteLine("Name= {0}", StudentName);
            Console.WriteLine("School= {0}", SchoolName);
            Console.WriteLine("Age {0}", Age);
            Console.Writeline("Location={0}", Location);

            Console.Read();

        }
    }
}
