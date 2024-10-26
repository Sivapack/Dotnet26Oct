
using System;
class Program
{
 static void Increment(int number)
 {
 number++;
 Console.WriteLine("Inside Increment method: " + number);
 }

 static void Main()
 {
 int value = 10;
 Console.WriteLine("Before calling Increment method: " + value);
 Increment(value);
 Console.WriteLine("After calling Increment method: " + value);
 }
}
