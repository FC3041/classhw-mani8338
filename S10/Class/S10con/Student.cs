
using System.ComponentModel;

public class Student:IDisposable  //means this class has the capability of being disposed. this a interface which ensures that this class has that capability
{
    private string Name;

    public Student(string name)
    {
        this.Name = name;
        Register();
    }

    ~Student()
    {
        System.Console.WriteLine($"{Name} is dying");
    }

    public void Register()
    {
        System.Console.WriteLine($"{Name} is registered");
    }

    public void Dispose()
    {
        System.Console.WriteLine($"{Name} is unregistered");
    }
}