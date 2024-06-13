using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    
    internal class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string YearOfBirth { get; set; }

        public Dog(int id, string name, string race, string birthYear) 
        {
            ID = id;
            Name = name;
            Race = race;
            YearOfBirth = birthYear;
        }

        public override string ToString()
        {
            return $"ID: {ID} - Name: {Name} - Race: {Race} - Year of Birth: {YearOfBirth}";
        }
    }
}
