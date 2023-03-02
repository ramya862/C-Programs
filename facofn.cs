using System;
namespace factorial
{
 class myclass
 {
 static void Main(string[] args)
 {
 int n=5;
 int fac=1;
 while(n!=0)
 {
  fac=fac*n;
  n=n-1;
 }
 Console.WriteLine(fac);
 }
 }
 }
  
