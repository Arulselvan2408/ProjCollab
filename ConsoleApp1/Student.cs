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
            Console.WriteLine("Enter the StudentName");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter the SchoolName");
            SchoolName = Console.ReadLine(); 
            Console.WriteLine("Enter Location");
            string Location=Console.ReadLine();
            Console.WriteLine("enter the student ID");
            int StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the DOB");
            string DOB = Console.ReadLine();
            Console.WriteLine("Name= {0}", StudentName);
            Console.WriteLine("School= {0}", SchoolName);
            Console.WriteLine("Location={0}", Location);
            Console.WriteLine("StudentId= {0}", StudentID);
            Console.WriteLine("DOB={0}", DOB);
            
            Console.Read();

        }
    }
}
