using Polymorphism;

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("lion", 100);
        Tiger tiger = new Tiger("tiger", 200);
        
        lion.Show();
        
        tiger.Show();
    }
}