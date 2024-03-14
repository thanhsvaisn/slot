using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;
class Animal
{
    protected string name;
    protected double weight;


    public Animal(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }


    public void Show()
    {
        Console.Write($"Name: {name} , ");
        Console.WriteLine($"Weight: {weight} kg ");
    }

    public void SetMe(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }
}
