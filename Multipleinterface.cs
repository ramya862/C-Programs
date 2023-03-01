using System;
namespace myapp
{
interface hi
{
 void himethod();
}
interface hello
{
void hellomethod();
}
class greeting:hi,hello
{
public void himethod()
{
Console.WriteLine("Im hi method");
}
public void hellomethod()
{
Console.WriteLine("Im hello method");
}
}
class Main1
{
 static void Main(string[] args)
 {
  greeting g=new greeting();
  g.himethod();
  g.hellomethod();
 }
}
}
 
