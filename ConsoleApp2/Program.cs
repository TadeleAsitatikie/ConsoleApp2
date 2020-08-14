using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of GitHub Visual Studio");
            Student s = new Student();
            s.Name = "Abel Yilak";
            s.dept = "Electrical Engineering";
            Console.WriteLine("Student name     Student Department");
            Console.WriteLine(s.Name + "    "+s.dept);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
