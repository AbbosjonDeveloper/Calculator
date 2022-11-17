using System;
System.Console.WriteLine("Type 1st number: ");
int firstNumber  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter oeration (+, -, *, /, % ) :");
string operation = Console.ReadLine();
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Ternary operator
string message = 
  firstNumber >= 0 
    ? "1st number is positive"
    : "1st number is negative";

string message2 = 
  secondNumber >= 0
    ? "2nd number is positive"
    : "2nd number is negative";
  System.Console.WriteLine(message);
  System.Console.WriteLine(message2);

// if else
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

// Switch expressions
string result = operation switch 
{
  "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
  "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
  "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
  "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
  "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
  _   => "Operation Not Found!"
};
System.Console.WriteLine(result);
// While loop
if (firstNumber > 0) 
{
  int count = 1;
  while (count < firstNumber )
  {
    count++;
    if (count % 2 == 0)
    {
      System.Console.WriteLine(count);
    }
  }
}
