using System;
namespace OOP_Exercises
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} Parrot.");
        }

    }
}