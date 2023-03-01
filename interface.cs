using System;
namespace myapp
{
interface ihey
{
void mymethod();
}
class hii:ihey
{
 public void mymethod()
 {
 Console.WriteLine("I\'m the implementation of an interface");
 }
 }
 class Main1
 {
 static void Main(string[] args)
 {
 hii h=new hii();
 h.mymethod();
 }
 }
 }
