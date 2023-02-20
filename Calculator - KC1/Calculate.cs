using System;  // allows to use System namespace and therefore use Console.Write 
using System.Collections.Generic; // allows to use Lists
using System.Linq; //allows to use functions similar to SQL
using System.Text; // allows to use ASCII and Unicode
using System.Threading.Tasks; // need more learning, don't recall

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second) // a method called Add that allows you to declare two numbers
        {
            return first + second; // returns the declared numbers in Add added together
        }

        public int Subtract(int first, int second) // same as above for subtraction
        {
            return first - second;
        }

        public int Multiply(int first, int second) //same as above for multiplication
        {
            // throw new NotImplementedException();
            // replaced original item for correct multiplication equation, as part of instructions

            return first * second;
        }

        public double Divide(double first, double second) // same as above for division
        {
            return first / second;
        }
    }
}