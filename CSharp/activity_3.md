# Activity 3
## Introduction to Inheritance

## Exercise 3.1 - Introductory Reading - Inheritance

### Pillar 3 - What is 'Inheritance'?

When modelling classes using Object-Oriented Programming, we may want to have a class inherit state & behaviour from another class. This concept is called 'inheritance'. Just like bear cubs can inherit traits from their parents; it is the same when modelling systems. We call the parent class the 'base or superclass' and any particular class which inherits (i.e. extends) from this base class the 'subclass'. It is often the case that the base class constitutes the most common attributes and behaviours.

In the Animal Kingdom, we can have a class hierarchy like the following:

- Animal -> Bird -> Parakeet

The Animal class is highest in the hierarchy, so it's contains the blueprint for what it means to be an Animal. The Bird class is a type of Animal but is more specific and defines the attributes and behaviours most common to Birds. A Parakeet is a type of Bird and it's even more concrete.

## Exercise 3.2 - Representing Inheritance in Class Diagrams & Unified Modelling Language (UML)

- Can you do some research to find out how to represent inheritance in Class Diagrams?

- Draw a diagram to show a `Pigeon` subclass extending the base class `Bird`

## Exercise 3.3 - Translate the class diagram into code to create a subclass `Pigeon` class which extends the base class `Bird`

In your existing .NET Console application project:

- Add an empty class called `Pigeon`
- Add the following code to make the `Pigeon` extend base class `Bird`

```csharp

//The Pigeon extends the base class Bird
public class Pigeon : Bird
{
    //The Pigeon constructor calls the base class Bird constructor
    //The name and color parameters are passed to the Bird constructor
    public Pigeon(string name, string color) : base(name, color)
    {
    }
}

```

