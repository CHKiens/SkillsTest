using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillsTest
{
    internal class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; }
        public List<Room> Rooms { get; set; }

        public Member(int id, string name, string adress, DateTime birthDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Adress = adress;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dogs = new List<Dog> { };
            Rooms = new List<Room> { };
        }
        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year; }
        }

        public double MemberFee(double baseFee)
        {
            if (this.Age > 65)
            {
                baseFee = 500;
                return Dogs.Count * baseFee;
            }
            else if (Dogs.Count > 2 && this.Age < 65)
            {
                baseFee = 500;
                return 1000 + Dogs.Count-1 * baseFee;

            }
            return Dogs.Count* baseFee;

            

        }

        public void Validate()
        {
            if (this.Age < 18)
            {
                Exception e = new Exception("Age must be 18 or above");
                throw e;
            }
            else if (string.IsNullOrEmpty(this.Name))
            {
                Exception e = new Exception("Validation Unsuccessful - missing Name input");
                throw e;
            }
            else if (string.IsNullOrEmpty(this.Adress))
            {
                Exception e = new Exception("Validation Unsuccessful - missing Adress input");
                throw e;
            }
            else if (string.IsNullOrEmpty(this.Phone))
            {
                Exception e = new Exception("Validation Unsuccessful - missing Phone input");
                throw e;
            }
            else if (string.IsNullOrEmpty(this.Email))
            {
                Exception e = new Exception("Validation Unsuccessful - missing Email input");
                throw e;
            }
            else
            {
                Console.WriteLine("Validation Successful");
            }

        }

        //public void Validate()
        //{
        //    try { }
        //}
        public void RegisterDog(Dog dog)
        {
            Dogs.Add(dog);
            Console.WriteLine($"Added {dog.Name} to {this.Name}");
            
        }

        

        public void RemoveDog(Dog dog)
        {
            Dogs.Remove(dog);
            Console.WriteLine($"Removed {dog.Name} from {this.Name}");
        }
        public void RegisterRoom(Room room, DateTime startDate, DateTime endDate)
        {
            if (room.RentedOut == false)
            {
                room.DateStart = startDate;
                room.DateStart = endDate;
                room.RentedOut = true;
                Rooms.Add(room);
                Console.WriteLine($"Added {room.Name} to {this.Name}");
            }
            else
            {
                Console.WriteLine($"{room.Name} already rented out to {this.Name}");
            }

        }
        public void RemoveRoom(Room room)
        {
            room.RentedOut = false;
            Rooms.Remove(room);
            Console.WriteLine($"Removed {room.Name} from {this.Name}");
        }

        public void PrintDogs()
        {
            Console.WriteLine($"{Name} owns:");
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"ID: {dog.ID} - Name: {dog.Name} - Race: {dog.Race} - Year of Birth: {dog.YearOfBirth}");
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"ID: {ID} - Name: {Name} - Adress: {Adress} -" +
                $" Birth Date: {BirthDate}\nPhone: {Phone} - Email: {Email}\n";
                ;
        }
    }
    
}
