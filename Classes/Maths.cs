using System;
namespace CALCULATOR.Classes
{
    class Maths 
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        

        // public Maths(int firstNumber, int secondNumber)
        // {
        //     FirstNumber = firstNumber;
        //     SecondNumber = secondNumber;
            
        // }
        public void PrintPassword() 
        {
            string password = "";
            do 
            {
            System.Console.WriteLine("Enter password");
            password = System.Console.ReadLine();
            }while(password != "aaa");
        }
        public void CheckPosOrNeg(int firstNumber, int secondNumber)
        {
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
        }
        public void CompareNumbers(int firstNumber, int secondNumber)
        {
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
        }
        public void PrintResult(int firstNumber, int secondNumber, string operation)
        {
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
        }
        public void PrintEvenNumbers(int firstNumber)
        {
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
        }
        public void PrintMultiplicationTable()
        {
            // for loop
            for (int iterator = 1; iterator <= 10; iterator++ )
            {
                for (int innerIterator = 1; innerIterator <=10; innerIterator++) 
                {
                System.Console.WriteLine($"{iterator} * {innerIterator} = {iterator * innerIterator}");
                }
                System.Console.Write("\n");
            }
        }
    }
}