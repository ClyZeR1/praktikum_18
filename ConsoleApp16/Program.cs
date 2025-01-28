using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
        Person dmitriy = new Person("Dmitriy", "Starodub", 17);
        Console.WriteLine(dmitriy);
    }
}

class Person
{
    private string name;
    private string lastName;
    private int age;

    public Person(string name, string lastName, int age)
    {
        this.name = name;
        this.lastName = lastName;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Имя и фамилия: {name} {lastName}, возраст: {age}";
    }
}
