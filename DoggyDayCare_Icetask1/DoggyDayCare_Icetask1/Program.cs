namespace DoggyDayCare_Icetask1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Doggo dog = new Doggo(3, 15, 3, "Pitbull", "Hunter");

            //Console.WriteLine(dog[0]); 
            //Console.WriteLine(dog[1]);
            //Console.WriteLine(dog[2]);
            //Console.WriteLine(dog[3]);
            //Console.WriteLine(dog[4]);

            Console.WriteLine("Dog Age: " + dog["age"]); 
            Console.WriteLine("Dog Weight: " + dog["weight"]);
            Console.WriteLine("Kennel Number: " + dog["kennel"]);
            Console.WriteLine("Dog Breed: " + dog["breed"]);
            Console.WriteLine("Dog Name: " + dog["name"]);
        }
    }
}
