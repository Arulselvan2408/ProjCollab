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
            string StudentName, SchoolName,studentfathername;
            int Age;
            Console.WriteLine("Enter the StudentName");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter the SchoolName");
            SchoolName = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Location");
            string Location=Console.Readline();
            Console.Writeline("enter the student ID");
            int StudentID = Convert.ToInt32(Console.Readline());
            Console.WriteLine("Enter the studentfathername")
          
            Console.WriteLine("Name= {0}", StudentName);
            Console.WriteLine("School= {0}", SchoolName);
            Console.WriteLine("Age {0}", Age);
            Console.Writeline("Location={0}", Location);
            Console.Writeline("StudentId= {0}", StidentID);
            
            Console.Read();

        }
    }
}
