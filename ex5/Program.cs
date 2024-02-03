

using ex5;

var person =new Person("Name","Address");

var student = new Student("Amin","Profsoyuz","OOP",18,1.3);
System.Console.WriteLine(student.GetName());
System.Console.WriteLine(student.GetAddress());
System.Console.WriteLine(student.GetProgram());
System.Console.WriteLine(student.GetYear());
System.Console.WriteLine(student.GetFee());
System.Console.WriteLine("--------------------------");

var staff =new Staff("Qrbon","Russia","school of Asia",1200.1);
System.Console.WriteLine(staff.GetName());
System.Console.WriteLine(staff.GetAddress());
System.Console.WriteLine(staff.GetSchool());
System.Console.WriteLine(staff.GetPay());
System.Console.WriteLine("--------------------------");
