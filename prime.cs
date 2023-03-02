using System;
namespace prime
{
class myc
{
static void Main(string[] args)
{
int n=8;
int factor=2;
for(int i=2;i<n;i++)
{
 if (n%i==0)
  {
   factor+=1;
  }
}
if(factor>2)
{
 Console.WriteLine("Not Prime");
}
else
{
 Console.WriteLine("Prime");
}
}
}
}
 
