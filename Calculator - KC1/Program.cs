using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division"); // prompt user to select the type of calculation

            var input = Console.ReadLine(); //read the selection
            var calculator = new Calculator(); //instigate new calculator

            switch (input) //based on input switch to
            {
                case "1": //based on selection do the following
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    // this is a try if the number is a number otherwise throw an error message. It is repeated in all the cases and could possibly be made it's own class and reused
                    // but I am not sure how to make it work yet, See Entry Verification for my attemp.

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo)) 
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subtractNumber1 = Console.ReadLine();
                    var subtractNumber2 = Console.ReadLine();

                    if (int.TryParse(subtractNumber1, out int subNumOne) && int.TryParse(subtractNumber2, out int subNumTwo))
                    {
                        Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var multiplyNumber1 = Console.ReadLine();
                    var multiplyNumber2 = Console.ReadLine();

                    if (int.TryParse(multiplyNumber1, out int multNumOne) && int.TryParse(multiplyNumber2, out int multNumTwo))
                    {
                        Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not an int");
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}