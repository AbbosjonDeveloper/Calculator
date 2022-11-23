using System;
namespace CALCULATOR.Classes
{
    class Maths 
    {
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }
        private string Operation { get; set; }

        

        public void EnterPassword() 
        {
            string password = "";
            do 
            {
                System.Console.WriteLine("Enter password");
                password = System.Console.ReadLine();
            } while(password != "aaa");    
            
        }

        public void EnteringNumbers()
        {
            System.Console.WriteLine("Type 1st number: ");
            FirstNumber  = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter operation (+, -, *, /, % ) :");
            Operation = Console.ReadLine();
            System.Console.WriteLine("Type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void CheckPosOrNeg()
        {
            // Ternary operator
            string message = 
                FirstNumber >= 0 
                ? "1st number is positive"
                : "1st number is negative";

            string message2 = 
                SecondNumber >= 0
                ? "2nd number is positive"
                : "2nd number is negative";
                System.Console.WriteLine(message);
                System.Console.WriteLine(message2);
        }
        public void CompareNumbers()
        {
            // if else
            if (FirstNumber > SecondNumber)
            {
                System.Console.WriteLine("The first number is bigger!");
            }
            else if (SecondNumber > FirstNumber)
            {
                System.Console.WriteLine("The second number is bigger!");
            }
            else
            {
                System.Console.WriteLine("They are equal!");
            }
        }
        public void PrintResult()
        {
            // Switch expressions
            string result = Operation switch 
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber}",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber}",
                _   => "Operation Not Found!"
            };
            System.Console.WriteLine(result);
        }
        public void PrintEvenNumbers()
        {
            // While loop
            if (FirstNumber > 0) 
            {
                int count = 1;
                while (count < FirstNumber )
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