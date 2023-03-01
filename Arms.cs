using System;
namespace myapp
{
class Main1
{
static void Main(string[] args)
{
int n=153;
int temp;
temp=n;
int ams=0;
int digit;
while(n>0)
{
digit=n%10;
ams=ams+digit*digit*digit;
n/=10;
}
if(temp==ams)
{
Console.WriteLine("Armstrong number");
}
else
{
Console.WriteLine("Not armstrong");
}
}
}
}
