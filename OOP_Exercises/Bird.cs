using System;
namespace OOP_Exercises
{
    public abstract class Bird
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        //This method is marked with Abstract keyword
        //This means that any classes extending on Bird must implement this
        //Abstract methods don't have a method body
        public abstract void Speak();

        public virtual void Fly()
        {
            //Default implementation
            Console.WriteLine("Hi there! I can fly.");
        }
        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
        }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
}
