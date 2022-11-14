using System;
System.Console.WriteLine("Type 1st number: ");
int firstNumber  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
  System.Console.WriteLine("The first number is bigger!");
}
else if (secondNumber > firstNumber)
{
  System.Console.WriteLine("The second number is bigger!");
}
else
{
  System.Console.WriteLine("They are equal!");
}





