/* Commenting out the entire Class. This was my attempt at trying to make reusable components. 
Didn't work so well. Will revisit when I have a better understanding

namespace KnowledgeCheck1_Calculator
{
    //plan is to move TryParse and number selection here
    public class EntryVerification
    {



        // creates an object array which will have a mixture of string and int and bool and we can check call its values by index as needed
        public static (string mathselect, int number1, int number2, string math) Check(params string[] items) // object[] didn't work so swithced to striing. Need to do more research
        {
            {
                items[0] = Console.ReadLine(); // not sure if this is going to work, I want it to read line from Programs.Cs
                items[1] = Console.ReadLine();
                items[2] = Console.ReadLine();

                if (items[0] == "1") // based on input 
                    items[3] = "+"; //the mathimatical equation will display
                else if (items[0] == "2")
                    items[3] = "-";
                else if (items[0] == "3")
                    items[3] = "x";
                else if (items[0] == "4")
                    items[3] = "/";

                if (int.TryParse(items[1], out int num1) && int.TryParse(items[1], out int num2)) // if the number entered at index 0 and index 1 is an integer then set it to new int names

                {
                    Console.WriteLine($"{num1} {items[3]} {num2} = "); //use those names to print a message
                }

                else
                {
                    Console.WriteLine("One or more of the numbers is not an int"); //if not integers print this message
                }

            }
        }
    }
}

*/