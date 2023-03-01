using System;
namespace myapp
{
class exofclass
{
public int x=10;
public string name="Ramya";
public void mymethod()
{
 Console.WriteLine("This is my method my objects can use it");
}
}
class Main1
{
protected int a=7;
static void Main(string[] args)
{
exofclass obj= new exofclass();
Console.WriteLine(obj.x);
Console.WriteLine(obj.name);
obj.mymethod();
Main1 obj1=new Main1();
Console.WriteLine(obj1.a);
}
}
}
