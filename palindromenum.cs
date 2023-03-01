using System;
namespace myapp
{
class Main1
{
static void Main(string[] args)
{
int n=151;
int temp;
temp=n;
int rev=0;
int digit;
while(n!=0)
{
digit=n%10;
rev=rev*10+digit;
n/=10;
}
if(temp==rev)
{
Console.WriteLine("Palindrome number");
}
else
{
Console.WriteLine("Not armstrong");
}
}
}
}
