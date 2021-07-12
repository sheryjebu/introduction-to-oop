# Activity 5
## Introduction to Interfaces

## Exercise 5.1 - Introductory Reading - Interfaces

### What is an 'Multiple inheritance'?

Multiple inheritance is where a class can inherit from more than one parent class. This could lead to something called the Diamond Problem where the same state or behaviour can be defined in multiple parent classes, so the subclass won't know which one to inherit from. 

C# doesn't support multiple inheritance. A subclass can only inherit from one base class.

### What is an 'Interface'?

'Interfaces' were invented as a way of defining the things objects can do i.e. their jobs. Any class that implements the interface must implement all of the members defined in the interface; a 'contract' is a term often used to describe interfaces. A class can only inherit from a single base class, but a class can implement many interfaces.

## Exercise 5.1 - Create an interface `IDance`

Let's use an interface to add some dance moves to our `Bird` class.

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

In your existing .NET Console application project:

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
        Console.WriteLine($"I'm spinning now!");
    }

    public void DoTheCaterpillar()
    {
        Console.WriteLine($"Wriggly woo!");
    }

    public void Jump()
    {
        Console.WriteLine($"Jump in the air!");
    }
}

```