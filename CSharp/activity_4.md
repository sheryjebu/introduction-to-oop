# Activity 4
## Introduction to Polymorphism

## Exercise 4.1 - Introductory Reading - Polymorphism & Abstract Classes

### Pillar 4 - What is 'Polymorphism'?

Polymorphism means many shapes or forms. Building on top of what we know about classes, abstraction, encapsulation and inheritance, we can provide flexibility for subclasses to implement something in many different forms. One tool that can be used to enable Polymorphism is called 'Abstract' classes.

### What is an Abstract class?

An Abstract class is an intentionally incomplete class. This means that it's the job of subclasses which extend on the Abstract class to provide meaning (implementation) for the attributes and methods defined in the abstract class. Abstract classes enable Software Engineers to collate functionality that subclasses can implement or override.

---

## Exercise 4.2 - Make the base class `Bird` an abstract class

In your existing .NET Console application project:

- Make your existing `Bird` class an abstract class

```csharp

public abstract class Bird
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
}

```
---

## Exercise 4.3 - Edit the `Pigeon` class to override methods defined by the `Bird` class

In your existing .NET Console application project:

- In your existing `Pigeon` class, add the following implementation for the `Speak()` method by overriding the abstract class `Speak()` method. Notice that for the `Pigeon` class, we'd like to use the default implementation for `Fly()` which is defined in the abstract class.

```csharp

//The Pigeon extends the base class Bird
public class Pigeon : Bird
{
    //The Pigeon constructor calls the base class Bird constructor
    //The name and color parameters are passed to the Bird constructor
    public Pigeon(string name, string color) : base(name, color)
    {
    }

    public override void Speak() 
    {
        Console.WriteLine($"Yo! I'm {name} and I'm a {color} pigeon.");
    }
}

```

---

## Exercise 4.4 - Create the additional subclasses `Penguin` to extend the base class `Bird`

In your existing .NET Console application project:

- Add an empty class called `Penguin`
- Add the following code to make the `Penguin` extend base class `Bird`

```csharp

public class Penguin : Bird
{
    public Penguin(string name, string color) : base(name, color)
    {
    }

    public override void Speak() 
    {
        Console.WriteLine($"Yo! I'm {name} and I'm a {color} penguin.");
    }

    public override void Fly() 
    {
        Console.WriteLine($"Whoops, I can't fly.");
    }
}

```