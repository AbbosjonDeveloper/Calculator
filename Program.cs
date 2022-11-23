using System;
using CALCULATOR.Classes;

namespace CALCULATOR
{
  class Program
  {
    static void Main()
    {
      Maths calculator = new Maths();

      calculator.EnterPassword();

      calculator.EnteringNumbers();
      
      calculator.CheckPosOrNeg();
      calculator.CompareNumbers();
      calculator.PrintResult();
      calculator.PrintEvenNumbers();
      calculator.PrintMultiplicationTable();
          }
        }
      }
