using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    internal class Room
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        public bool RentedOut { get; set; }

        public Room(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name} ";
        }
    }

    
}
