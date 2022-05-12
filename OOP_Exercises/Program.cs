using System;

namespace OOP_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bird myBird = new Bird("Tweety", "Yellow");
            myBird.Speak();
            myBird.Fly();*/

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();
            pippa.Spin();
            pippa.DoTheCaterpillar();
            pippa.Jump();

            Parrot parrot = new Parrot("Chakki", "Green");
            parrot.Speak();
            parrot.Spin();
            parrot.DoTheCaterpillar();
            parrot.Jump();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Spin();
            pingu.DoTheCaterpillar();
            pingu.Jump();

        }
    }
}
