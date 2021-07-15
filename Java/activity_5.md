# Activity 5
## Introduction to Interfaces

## Exercise 5.1 - Introductory Reading - Interfaces

### What is an 'Multiple inheritance'?

Multiple inheritance is where a class can inherit from more than one parent class. This could lead to something called the **Diamond Problem** where the same state or behaviour can be defined in multiple parent classes, so the subclass doesn't know which one to inherit from. 

**Java doesn't support multiple inheritance. A subclass can only inherit from one base class.**

### What is an 'Interface'?

Interfaces were invented as a way of defining the things objects can do i.e. their jobs.

Any class that implements an interface must implement all of the members defined in the interface; a 'contract' is a term often used to describe interfaces. A class can only inherit from a **single** base class, but a class can implement **many** interfaces.

---

## Exercise 5.1 - Representing interfaces in Unified Modelling Language (UML) diagrams

- Can you do some research to find out how to represent interfaces in UML diagrams?

- Draw a diagram to show the `Bird` class implementing the interface `DanceImpl`

- The `DanceImpl` interface contains the following methods that classes implementing the interface will provide an implementation for:

- Spin
- DoTheCaterpillar
- Jump

You can use pen and paper or any digital drawing tool you prefer.

---

## Exercise 5.2 - Create an interface `DanceImpl`

Let's use an interface to add some cool dance moves functionality to our existing `Bird` class so that all the subclasses that inherit `Bird` class can do some dancing too.

In your Java Console (Command Line) Application Project:

- Add an interface called `DanceImpl`

```java

public interface DanceImpl {

    void spin();
    void doTheCaterpillar();
    void jump();

}

```

## Exercise 5.3 - Implement the interface `DanceImpl` in Bird

Let's make our existing `Bird` class implement the interface `DanceImpl`.

- Implement `DanceImpl` in the `Bird` class

```java

public abstract class Bird implements DanceImpl {

    protected String name;
    protected String color;

    public Bird(String name, String color) {
        this.name = name;
        this.color = color;
    }

    public void speak() {
        //To be implemented in subclasses
    }

    public void fly() {
        System.out.println("Hi there! I can fly.");
    }

    public void spin() {
        System.out.println(name + " spin!");
    }

    public void doTheCaterpillar() {
        System.out.println(name + " do the wriggly woo!");
    }

    public void jump() {
        System.out.println(name + " jump in the air!");
    }
}

```

---

## Exercise 5.4 - Run your console application

- Add the following code to the `main` method in the `Main` class beneath your existing code for pippa the `Pigeon`.

```java

pippa.spin();
pippa.doTheCaterpillar();
pippa.jump();

```

- Add the following code to the `main` method in the `Main` class beneath your existing code for pingu the `Penguin`.

```java

pingu.spin();
pingu.doTheCaterpillar();
pingu.jump();

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