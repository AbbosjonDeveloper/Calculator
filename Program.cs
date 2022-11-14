using System;
System.Console.WriteLine("Type 1st number: ");
int firstNumber  = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Adding {firstNumber + secondNumber}");
// Console.WriteLine($"Subtructing {firstNumber - secondNumber}");
// Console.WriteLine($"Dividing {firstNumber / secondNumber}");
// Console.WriteLine($"Multiplying {firstNumber * secondNumber}");
// Console.WriteLine($"Remaining {firstNumber % secondNumber}");

System.Console.WriteLine($"The 1st number is greater than 2nd number : {firstNumber > secondNumber}");
System.Console.WriteLine($"The 1st number is greater or equal to  2nd number : {firstNumber >= secondNumber}");
System.Console.WriteLine($"The 2nd number is greater than 1st number : {firstNumber < secondNumber}");
System.Console.WriteLine($"The 2nd number is greater or equal to 1st number : {firstNumber <= secondNumber}");
System.Console.WriteLine($"The 1st number is equal to  2nd number : {firstNumber == secondNumber}");
System.Console.WriteLine($"The 1st number is not equal to  2nd  number : {firstNumber != secondNumber}");




