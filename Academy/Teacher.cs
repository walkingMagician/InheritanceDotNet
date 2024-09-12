using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Speciality { get; set; }
        int experience;
        public int Experience 
        {
            get => experience;
            set => experience = value < 70 ? value : 70; 
        }

        public Teacher
            (
            string lastNmae, string firstName, uint age,
            string speciality, int experience
            ) : base(lastNmae, firstName, age)
        { 
            Speciality = speciality;
            Experience = experience;
            Console.WriteLine($"T-Constructor:\t{GetHashCode()}");
        }

        ~Teacher()
        {
            Console.WriteLine($"T-Destructor:\t{GetHashCode()}");
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"{Speciality} {Experience}");
        }

        public override string ToString()
        {
            return $"{base.ToFileString()},{Speciality.PadRight(25)},{Experience.ToString().PadRight(8)}";
        }
        public override void Init(string[] values)
        {
            base.Init(values);
            Speciality = values[4];
            Experience = Convert.ToInt32(values[5]);
        }
    }
}
