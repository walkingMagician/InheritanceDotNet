using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Graduate:Student
    {
        public string Subject { get; set; }

        public Graduate
            (
            string lastNmae, string firstName, uint age,
            string speciality, string group, double rating, double attendance,
            string subject
            ) : base(lastNmae, firstName, age, speciality, group, rating, attendance)
        { 
            Subject = subject;
            Console.WriteLine($"G-Constructor:\t{GetHashCode()}");
        }

        public Graduate(Student student, string subject):base(student)
        {
            Subject = subject;
            Console.WriteLine($"G-Constructor_2:\t{GetHashCode()}");
        }

        ~Graduate()
        {
            Console.WriteLine($"G-Destructor:\t{GetHashCode()}");
        }

        public void print()
        {
            base.Print();
            Console.WriteLine($"{Subject}");
        }
        public override string ToString()
        {
            return base.ToString() + $" {Subject}";
        }

    }
}
