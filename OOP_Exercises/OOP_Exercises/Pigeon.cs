using System;
namespace OOP_Exercises
{
    public class Pigeon : Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }
        public void Sleep()
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }
    }
}
