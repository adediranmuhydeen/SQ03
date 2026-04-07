using System;
using System.Collections.Generic;
using System.Text;

namespace SQ03;

internal class Car
{
    public static int Tyres { get; set; }
    public static int Doors { get; set; }
    public static int Factor { get;}
    private static int myFactor;
    public static int MyFactor { get; set; }

    public static int Mutiplier(int a, int b, int c)
    {
        return a * b * c;
    }

    public static int Mutiplier(int b, int c)
    {
        return b * c;
    }

    public static void GetFactor()
    {
        myFactor = Tyres * Doors;
        Console.WriteLine($"The factor is {myFactor}");
    }

    public static int FindSmallestInt(int[] args)
    {
        var control = args[0];
        foreach (int n in args)
        {
            if (n < control)
            {
                control = n;
            }
        }
        return control;
    }

}

public class Animal : Mammal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int NumberOfLegs { get; set; }

    public override void MakeSound()
    {
        throw new NotImplementedException();
    }

    public int ReturnAge()
    {
        return Age;
    }

    public int ReturnAge(int years)
    {
        return Age + years;
    }

    public int ReturnAge(string name)
    {
        if (name == Name)
        {
            return Age;
        }
        else
        {
            return -1; // or throw an exception
        }
    }
}

public abstract class Mammal
{
    public bool HasFur { get; set; }
    public bool IsWarmBlooded { get; set; }

    public abstract void MakeSound();
}


public class Dog : Animal
{
    public string Breed { get; set; }
    public bool IsTrained { get; set; }
}

public class Bird : Mammal
{
    public double WingSpan { get; set; }
    public bool CanFly { get; set; }
    public override void MakeSound()
    {
        Console.WriteLine("Chirp!");
    }
}


