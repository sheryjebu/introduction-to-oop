# Activity 2
## Introduction to Object-Oriented Programming (OOP)

## Exercise 2.1 - Introductory Reading - Object-Oriented Programming (OOP)

### What is a Object-Oriented Programming (OOP)?

Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects'. The blueprint on how to make these 'objects' are defined by blueprints called 'classes'.

For example, I have a class which sets out the blueprint on how to make a gingerbread loaf cake. If I'm hungry, I can make many objects (instances) of a gingerbread loaf cake. Yummy! This process has a fancy name called 'instantiation'.

### Can you tell me what the Four Pillars of OOP are?

The Four Pillars of OOP are:

- Abstraction
- Encapsulation
- Inheritance
- Polymorphism

We've already explored the first pillar, which is Abstraction in Activity 1. Here's a quick recap.

### Pillar 1 - What is 'Abstraction'?

A model is a representation of reality; a computer model is a representation of reality in a computer. In Software Engineering, we need to think about the detail we are trying to capture and how we're going to abstract it i.e. capture the information we need to enable us to represent the behaviours of a given system in code.

Our next pillar is Encapsulation.

### Pillar 2 - What is Encapsulation?

Encapsulation means hiding the details of an object which is not supposed to be open for interaction. Any private details are kept well-encapsulated and hidden away, so that only details which are allowed to interact with other objects can be accessed from outside that object. In Software Engineering, this is important to protect an object from misuse.

---

## Exercise 2.2 - Introductory Reading - Class Diagrams & Unified Modelling Language (UML)

### What is a Class Diagram?

The Unified Modelling Language (UML) is a visualisation technique to visualize/model the design of a system in Software Engineering and can be applied by any set of programming languages or technologies.

A Class Diagram is part of the Unified Modelling Language (UML). You can read more about the Class Diagram [here](https://www.visual-paradigm.com/guide/uml-unified-modeling-language/what-is-class-diagram/).

---

## Exercise 2.2 - Draw a Class Diagram to represent a `Bird` class

In this exercise, use the Class Diagram from the Unified Modelling Language (UML) to model a `Bird` class with the with the following attributes and methods (behaviours). These attributes and methods (behaviours) are often called 'members' of a class. All of the following class members are public i.e. they are open for interaction from outside of that class.

Attributes:
- Name, Color

Methods:
- Speak, Fly

---

## Exercise 2.3 - Translate the class diagram into code to create a ‘Bird’ class

- Create a new .NET 5 Console Application Project
- Add an empty class called `Bird`
- Add the following code to create the `Bird` class

```csharp

public class Bird
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public void Speak() 
    {
        Console.WriteLine($"My name is {name} and I am a {color} bird.");
    }

    public void Fly() 
    {
        Console.WriteLine("I can fly high in the blue sky!");
    }
}

```

---

**Key Study Notes**

*Object-Oriented Programming* - Object-Oriented Programming (OOP) is a Software Engineering paradigm to enable the ability to model real-world things as 'objects'. The blueprint on how to make these 'objects' are defined by blueprints called 'classes'.

*Encapsulation* - Encapsulation means hiding the details of an object which is not supposed to be open for interaction.