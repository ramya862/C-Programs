using System;
namespace myapp
{
class Main1
{
static void Main(string[] args)
{
int n=125;
int rev=0;
int digit;
while(n!=0)
{
digit=n%10;
rev=rev*10+digit;
n/=10;
}
Console.WriteLine(rev);
}
}
}
