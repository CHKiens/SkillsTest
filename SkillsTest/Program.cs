using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Rollo", "Golden Retriever", "2020");
            Dog dog2 = new Dog(2, "Aslan", "Labrador", "2018");
            Dog dog3 = new Dog(3, "Humle", "Broholmer", "2019");
            Dog dog4 = new Dog(4, "Sheriff", "German Shephard", "2015");
            Dog dog5 = new Dog(5, "Aslan", "Mastiff", "2020");

            Member member1 = new Member(1, "Anders", "", new DateTime(1995, 5, 4), "20 20 20 20", "and@gmail.com");
            Member member2 = new Member(2, "Lone", "Fiolstræde 15", new DateTime(1984, 12, 10), "88 88 88 88", "lone@gmail.com");
            Member member3 = new Member(3, "Ole", "Peter Bangs Vej 125", new DateTime(1953, 2, 12), "", "ole@gmail.com");

            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);

            Console.WriteLine(member1);
            Console.WriteLine(member2);

            member1.RegisterDog(dog1);
            member1.RegisterDog(dog3);
            member2.RegisterDog(dog2);
            member3.RegisterDog(dog4);
            member3.RegisterDog(dog4);

            member1.PrintDogs();
            member2.PrintDogs();

            member1.RemoveDog(dog1);
            member1.PrintDogs();

            member1.RegisterDog(dog1);

            Console.WriteLine($"{member1.Name} Age: {member1.Age}");
            Console.WriteLine($"{member2.Name} Age: {member2.Age}");
            Console.WriteLine($"{member2.Name} Age: {member3.Age}");
            Console.WriteLine();

            Console.WriteLine("Basefee 1000");
            Console.WriteLine($"{member1.Name} Member Fee: {member1.MemberFee(1000)} kr.");
            Console.WriteLine($"{member2.Name} Member Fee: {member2.MemberFee(1000)} kr.");
            Console.WriteLine($"{member3.Name} Member Fee: {member3.MemberFee(1000)} kr.");

            
            try
            {
                member3.Validate();
            }
            catch (Exception e) { Console.WriteLine($"{e.Message}"); }
            
        }
    }
}
