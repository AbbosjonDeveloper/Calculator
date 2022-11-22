using System;
using CALCULATOR.Classes;

namespace CALCULATOR
{
  class Program
  {
    static void Main()
    {
      Maths calculator = new Maths();
      calculator.PrintPassword();

      System.Console.WriteLine("Type 1st number: ");
      int firstNumber  = Convert.ToInt32(Console.ReadLine());
      System.Console.WriteLine("Enter oeration (+, -, *, /, % ) :");
      string operation = Console.ReadLine();
      System.Console.WriteLine("Type 2nd number: ");
      int secondNumber = Convert.ToInt32(Console.ReadLine());

      calculator.CheckPosOrNeg(firstNumber, secondNumber);
      calculator.CompareNumbers(firstNumber, secondNumber);
      calculator.PrintResult(firstNumber, secondNumber, operation);
      calculator.PrintEvenNumbers(firstNumber);
      calculator.PrintMultiplicationTable();
          }
        }
      }
