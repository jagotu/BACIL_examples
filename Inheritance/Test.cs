using System;
using BACILHelpers;

class Animal
{
    private string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual string getSound()
    {
        return "Confused screeches";
    }

    public string getName()
    {
        return name;
    }
}

class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string getSound()
    {
        return "Meow";
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override string getSound()
    {
        return "Woof";
    }
}

class Test
{

    public static int Run()
    {
        Cat k = new Cat("Micka");
        Dog p = new Dog("Rex");
        print(k);
        print(p);
        return 4;
    }

    static void print(Animal z)
    {
        BACILConsole.Write(z.getName());
        BACILConsole.Write(": ");
        BACILConsole.Write(z.getSound());
        BACILConsole.Write("\n");
    }


}
