// #define INHERITANCE_1
// #define INHERITANCE_2
#define SAVE_TO_FALE
//#define LOAD_FROM_FALE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

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

#if SAVE_TO_FALE
            // Generalization
            Human[] group = new Human[]
                {
                    new Student("Pinkman", "Jessie", 25, "Chemistry","ww-220", 95, 97),
                    new Teacher("White", "Walter", 50, "Chemistry", 25),
                    new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 50, 80, " How to cath Heisenberg")
                };

            for (int i = 0; i < group.Length; i++)
            { 
                Console.WriteLine(group[i]);
            }

            string FileName = "group.csv";
            Save(group, FileName);
#endif
#if LOAD_FROM_FALE
            Human[] group = Load("group.csv");
            Print(group);
#endif
        }
        static void Save(Human[] group, string FileName)
        {
            StreamWriter sw = new StreamWriter(FileName);
            for (int i = 0; i < group.Length; i++)
            {
                sw.WriteLine(group[i].ToFileString());
            }
            sw.Close();
            //csv - comma separated values
            System.Diagnostics.Process.Start("excel", FileName);
        }
        static void Print(Human[] group)
        {
            for (int i = 0; i < group.Length; i++)
            {
               Console.WriteLine(group[i]);
            }
            
        }

        static Human[] Load(string filename)
        {
                List<Human> group = new List<Human>();
            try
            {
                StreamReader sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string buffer = sr.ReadLine();
                    string[] values = buffer.Split( ',', ';');
                    group.Add(HumanFactory(values[0]));
                    group.Last().Init(values);
                    
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return group.ToArray();
        }
        static Human HumanFactory(string type)
        {
            Human human = null;
            switch (type)
            {
                case "Teacher": human = new Teacher("", "", 0, "", 0); break;
                case "Student": human = new Student("", "", 0, "", "",  0, 0); break;
                case "Graduate": human = new Graduate("", "", 0, "", "",  0, 0, ""); break;
                    default: human = new Human("", "", 0); break;
            }
            return human;
        }


    }
}
