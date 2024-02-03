namespace ex6;

public class Dog : Animal
{
    public Dog(string name):base(name)
    {}
    public void Greets()
    {
        System.Console.WriteLine("Woof");
        System.Console.WriteLine("Wooooof");
    }
}
