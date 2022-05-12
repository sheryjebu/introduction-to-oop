using System;
namespace OOP_Exercises
{
    public class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} penguin.");
        }
        public override void Fly()
        {
            Console.WriteLine("Whoops, I can't fly. Waddle waddle.");
        }

    }
}
