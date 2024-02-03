namespace ex5;

public class Person
{
    string _name;
    string _address;
    public Person(string name,string address)
    {
        _name=name;
        _address=address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address;
    }
    public void SetAddress(string address)
    {
        address=_address;
    }
    public string ToString()
    {
        return $"Person  {_name} {_address}";
    }
}
