// #define INHERITANCE_1
// #define INHERITANCE_2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Program
    {
        static readonly string delimiter = "\n-----------------------------------\n";
        static void Main(string[] args)
        {
#if INHERITANCE_1
            Human human = new Human("Montana", "Antonio", 25);
            human.Print();
            Console.WriteLine(human);
            Console.WriteLine(delimiter);

            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry","ww-220", 95, 97);
            student.Print();
            Console.WriteLine(student);
            Console.WriteLine(delimiter);

            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
            teacher.Print();
            Console.WriteLine(teacher);
            Console.WriteLine(delimiter);

            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 80, " How to cath Heisenberg");
            graduate.Print();
            Console.WriteLine(graduate);
            Console.WriteLine(delimiter);
#endif

#if INHERITANCE_2
            Human tommy = new Human("Vercetty", "tommy", 30);
            Console.WriteLine(tommy);
            Console.WriteLine(delimiter);

            Human ken = new Human("Rozenberg", "ken", 35);
            Console.WriteLine(ken);
            Console.WriteLine(delimiter);

            Human diaz = new Human("Diaz", "Ricardo", 50);
            Console.WriteLine(diaz);
            Console.WriteLine(delimiter);

            Student S_tommy = new Student(tommy, "Theft", "vice", 98, 99);
            Console.WriteLine(S_tommy);
            Console.WriteLine(delimiter);

            Student s_ken = new Student(ken, "Lawer", "Vice", 42, 35);
            Console.WriteLine(s_ken);
            Console.WriteLine(delimiter);

            Graduate g_ken = new Graduate(s_ken, "how to many back");
            Console.WriteLine(g_ken);
            Console.WriteLine(delimiter);
#endif



        }
    }
}
