


List<int> number =new List<int> (){1,0,-4,5,10,-80,24,0,-4,100,24,45,6,-1};
System.Console.WriteLine(number.Max());
number.Sort();
for(int i=0;i<number.Count;i++)
{
    if(i<0)
    {
        i=0;
    }
}
