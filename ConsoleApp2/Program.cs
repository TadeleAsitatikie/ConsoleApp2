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
            Course c1 = new Course();
            c1.courseCode = "IT101";
            c1.courseTitle = "Java basics";
            c1.courseCredit = 4;
            Console.WriteLine("COurse Code     Course Title   Course Credit");
            Console.WriteLine(c1.courseCode +"  "+ c1.courseTitle+"  "+c1.courseCredit);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
