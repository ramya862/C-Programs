using System;
namespace hey
{
class bigofthree
{
static void Main(string[] args)
{
int a=10;
int b=15;
int c=5;
if(a>b&&a>c)
{
Console.WriteLine("a is greater than b and c");
}
else if(b>c&&b>a)
{
Console.WriteLine("b is greater than a and c");
}
else
{
Console.WriteLine("c is greater than a and b");
}

}
}
}
