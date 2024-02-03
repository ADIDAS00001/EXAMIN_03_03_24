namespace ex6;

public abstract class Animal
{
    string _name;
    public Animal(string name)
    {
        _name=name;   
    }
    public void Greets()
    {
        System.Console.WriteLine("Sound of Animals");
    }

}
