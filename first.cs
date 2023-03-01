using System;
namespace MyApplication
{
class oop
{
 public int speed=10;
 public string carname="Ford";
 public void carsound()
 {
 Console.WriteLine("Tut tut");
 }
}
class inherit:oop
{
string modelname="Mustang";
}
class Main1
{
static void Main(string[] args)
{
inherit x=new inherit();
Console.WriteLine(x.speed);
Console.WriteLine(x.carname);
x.carsound();
}
}
}
