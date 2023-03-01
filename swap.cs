using System;
namespace myapp
{
class hey
{
static void Main(string[] args)
{
int x=10;
int y=5;
int temp;
Console.WriteLine("The value of x and y before swapping x={0}, y={1}",x,y);
temp=x;
x=y;
y=temp;
Console.WriteLine("The value of x and y after swapping x={0} ,y={1}",x,y);
}
}
}
