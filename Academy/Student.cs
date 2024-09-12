using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Student:Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        double rating;
        double attendance;
        public double Ratiang 
        {
            get => rating;
            set => rating = value < 100 ? value : 100;
        }
        public double Attendance
        {
            get => attendance;
            set => attendance = value < 100 ? value : 100;
        }

        public Student
            (
            string lastNmae, string firstName, uint age,
            string speciality, string group, double rating, double attendance
            ):base(lastNmae, firstName, age)
        {
            Init(speciality, group, rating, attendance);
            Console.WriteLine($"S-Constructor:\t{GetHashCode()}");
        }

        public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
        {
            Init(speciality, group, rating, attendance);
            Console.WriteLine($"S-Constructor_2:\t{GetHashCode()}");
        }

        public Student(Student other):base(other)
        {
            Init(other.Speciality,other.Group , other.rating, other.attendance);
            Console.WriteLine($"S-CopyConstructor:\t{GetHashCode()}");
        }

        ~Student() 
        {
            Console.WriteLine($"S-Destructor:\t{GetHashCode()}");
        }

        void Init(string speciality, string group, double rating, double attendance)
        {
            Speciality = speciality;
            Group = group;
            Ratiang = rating;
            Attendance = attendance;
        }

        public void Print()
        { 
            base.Print();
            Console.WriteLine($"{Speciality} {Group} {Ratiang} {Attendance}");
        }
        public override string ToString()
        {
            return base.ToString() + $"{Speciality.PadRight(25)}{Group.PadRight(12)}{Ratiang.ToString().PadRight(8)}{Attendance.ToString().PadRight(8)}";
        }

        public override string ToFileString()
        {
            return $"{base.ToFileString()},{Speciality.PadRight(8)}, {Group.PadRight(10)}, {Ratiang.ToString().PadRight(10)},{Attendance.ToString().PadRight(8)}";
        }

        public override void Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Group = values[5];
            Ratiang = Convert.ToDouble(values[6]);
            Attendance = Convert.ToDouble(values[7]);
        }
    }
}
