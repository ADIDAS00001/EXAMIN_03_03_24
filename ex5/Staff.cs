namespace ex5;

public class Staff : Person
{
    string _school;
    double _pay;
    public Staff(string name,string address,string school,double pay)
    : base(name,address)
    {
        _school=school;
        _pay=pay;
    }
    public string GetSchool()
    {
        return _school;
    }
    public void SetSchool(string school)
    {
        school=_school;
    }
    public double GetPay()
    {
        return _pay;
    }
    public void SetPay(double pay)
    {
        pay=_pay;
    }
    public string ToString()
    {
        return ToString();
    } 
}
