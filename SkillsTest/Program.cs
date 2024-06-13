namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Rollo", "Golden Retriever", "2020");
            Dog dog2 = new Dog(2, "Aslan", "Labrador", "2018");
            Dog dog3 = new Dog(3, "Humle", "Broholmer", "2019");

            Member member1 = new Member(1, "Anders", "Københavnsvej 1", new DateTime(1995, 5, 4), "20 20 20 20", "and@gmail.com");
            Member member2 = new Member(1, "Lone", "Fiolstræde 15", new DateTime(1984, 12, 10), "88 88 88 88", "lone@gmail.com");

            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Console.WriteLine(dog3);

            Console.WriteLine(member1);
            Console.WriteLine(member2);

            member1.RegisterDog(dog1);
            member1.RegisterDog(dog3);
            member2.RegisterDog(dog2);

            member1.PrintDogs();
            member2.PrintDogs();

        }
    }
}
