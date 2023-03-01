using System;
namespace myapp
{
class oopc
{
public virtual void mymethod()
{
 Console.WriteLine("This is my method");
}
}
class poly:oopc
{
 public override void mymethod()
 {
 Console.WriteLine("I\'m poly class.This method was inherited from the parent class method");
 }
}
class poly1:oopc
{
public override void mymethod()
{
Console.WriteLine("I\'m poly1 class.This method was inherited from the parent classs method");
}
}
class Main1
{
static double add(double x, double y)
{
 return x+y;
}
static int add(int a,int b)
{
 return a+b;
}
static void Main(string[] args)
{
oopc obj=new oopc();
oopc obj1=new poly();
oopc obj2=new poly1();
obj.mymethod();
obj1.mymethod();
obj2.mymethod();
Console.WriteLine(add(2.5,7.8888));
Console.WriteLine(add(3,5));
}
}
}
