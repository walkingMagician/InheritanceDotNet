﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }
        
        public Human(string lastNmae, string firstName, uint age) 
        {
            LastName = lastNmae;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"H-Constructor:\t{GetHashCode()}");
            
        }

        public Human(Human other) 
        { 
            this.LastName = other.LastName;
            this.FirstName = other.FirstName;
            this.Age = other.Age;
            Console.WriteLine($"H-CopyConstructor:\t{GetHashCode()}");
        }

        ~Human()
        {
            Console.WriteLine($"H-Destructor:\t{GetHashCode()}");
        }

        public void Print()
        { 
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }

        public override string ToString()
        {
            return (base.ToString().Split('.').Last() + ":").PadRight(12)+$"{LastName.PadRight(12)} {FirstName.PadRight(12)} {Age.ToString().PadRight(10)}";
        }

        public virtual string ToFileString()
        {
            return $"{base.ToString().Split('.').Last()}:{LastName.PadRight(12)},{FirstName.PadRight(12)},{Age.ToString().PadRight(8)}";
        }

        public virtual void Init(string[] values)
        { 
            LastName = values[1];
            FirstName = values[2];
            Age = Convert.ToUInt32(values[3]);
        }
    }
}
