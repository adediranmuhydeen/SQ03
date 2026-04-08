using System;
using System.Collections.Generic;
using System.Text;

namespace SQ03;

public class ProperClass
{
}

public struct MyStruct
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public record MyRecord(string Name, int Age, int Identification);

public record SecondRecord
{
    public string Name { get; init; }
    public int Age { get; init; }
}

public interface IMyInterface
{
    public int MyProperty { get; set; }
    void MyMethod();
    int SecondMethod(string name);
    int ThirdMethod();
}

public abstract class MyAbstractClass
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //public abstract void AbstractMethod();
    public void NonAbstractMethod()
    {
        Console.WriteLine("This is a non-abstract method.");
    }
}

public class Student : MyAbstractClass
{
    public int ClassNumber { get; set; }

    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method in the Student class.");
    }
}

public class Teacher : MyAbstractClass
{
    public string Subject { get; set; }

    public class ClassTeacher
    {
        public string Subject { get; set; }

        public class ClassTeacherAssistant
        {
            public string Subject { get; set; }
        }
    }
}

public static class MyStaticClass
{
    public static int Id { get; set; }
    public static string FirstName { get; set; }
    public static string LastName { get; set; }
}

