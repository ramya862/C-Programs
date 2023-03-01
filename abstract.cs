using System;
namespace myapp
{
abstract class exofabstraction
{
public string me ="hi I\'m abstarct class";
public abstract void mymethod();
}
class child1:exofabstraction
{
public override void mymethod()
{
 Console.WriteLine("I\'m the implementation of abstarct method");
}
}
class Main1
{
static void Main(string[] args)
{
child1 obj= new child1();
obj.mymethod();
}
}
}
