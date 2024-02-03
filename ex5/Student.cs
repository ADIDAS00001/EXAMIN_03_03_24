namespace ex5;

public class Student : Person
{
    string _program;
    int _year;
    double _fee;
    public Student(string name,string address,string program,int year,double fee)
    : base(name,address)
    {
        _program=program;
        _year=year;
        _fee=fee;
    }
    public string GetProgram()
    {
        return _program;
    } 
    public void SetProgram(string program)
    {
        program=_program;
    } 
    public int GetYear()
    {
        return _year;
    } 
    public void SetProgram(int year)
    {
        year=_year;
    } 
    public double GetFee()
    {
        return _fee;
    } 
    public void SetFee(double fee)
    {
        fee=_fee;
    } 
    public string ToString()
    {
        return ToString();
    } 
}
