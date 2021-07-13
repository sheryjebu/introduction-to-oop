# Activity 5
## Introduction to Interfaces

## Exercise 5.1 - Introductory Reading - Interfaces

### What is an 'Multiple inheritance'?

Multiple inheritance is where a class can inherit from more than one parent class. This could lead to something called the **Diamond Problem** where the same state or behaviour can be defined in multiple parent classes, so the subclass doesn't know which one to inherit from. 

**C# doesn't support multiple inheritance. A subclass can only inherit from one base class.**

### What is an 'Interface'?

Interfaces were invented as a way of defining the things objects can do i.e. their jobs.

Any class that implements an interface must implement all of the members defined in the interface; a 'contract' is a term often used to describe interfaces. A class can only inherit from a **single** base class, but a class can implement **many** interfaces.

---

## Exercise 5.1 - Create an interface `IDance`

Let's use an interface to add some cool dance moves functionality to our existing `Bird` class so that all the subclasses that inherit `Bird` class can do some dancing too.

In your existing .NET Console application project:

- Add an empty interface called `IDance`

```csharp

public interface IDance
{
    void Spin();
    void DoTheCaterpillar();
    void Jump();
}

```

## Exercise 5.2 - Implement the interface `IDance` in Bird

Let's make our existing `Bird` class implement the interface `IDance`.

- Implement `IDance` in the `Bird` class

```csharp

public abstract class Bird : IDance
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public virtual void Speak() 
    {
    }

    public virtual void Fly() 
    {
        Console.WriteLine($"Hi there! I can fly.");
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

```

---

## Exercise 5.3 - Run your console application

- Add the following code to the `main` method in the `program.cs` file beneath your existing code for pippa the `Pigeon`.

```csharp

pippa.Spin();
pippa.DoTheCaterpillar();
pippa.Jump();

```

- Add the following code to the `main` method in the `program.cs` file beneath your existing code for pingu the `Penguin`.

```csharp

pingu.Spin();
pingu.DoTheCaterpillar();
pingu.Jump();

```

- Run your console application. You should see the following output to your console.

```

Yo! I'm Pippa and I'm a Grey pigeon.
Hi there! I can fly.
Pippa spin!
Pippa do the wriggly woo!
Pippa jump in the air!
Hi! I'm Pingu and I'm a Black & White penguin.
Whoops, I can't fly. Waddle waddle.
Pingu spin!
Pingu do the wriggly woo!
Pingu jump in the air!

```
---

### What's next?

Your learning journey doesn't stop here! Feel free to head back to review the concepts again. We encourage you to do some of your own research and experimentation in your own time to explore these concepts further.

---

### Key Study Notes

- *Interfaces* - invented as a way of defining the things objects can do i.e. their jobs. Any class that implements an interface must implement all of the members defined in the interface