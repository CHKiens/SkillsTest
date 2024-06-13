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
        public string Phone {  get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs{ get; set; }

        public Member(int id, string name, string adress, DateTime birthDate, string phone, string email)
        {
            ID = id;
            Name = name;
            Adress = adress;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Dogs = new List<Dog> { };
        }
        public int Age
        {
            get { return DateTime.Now.Year - BirthDate.Year ; }
        }

        public double MemberFee(double baseFee)
        {
            return Dogs.Count * baseFee;
            
        }
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
