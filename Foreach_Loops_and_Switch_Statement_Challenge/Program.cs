using System;

namespace Foreach_Loops_and_Switch_Statement_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            string userChoiceString;
            string runAgainAnswer;
            bool userInputEmpty = true;
            bool runAgain = true;
            bool userChoiceValid = false;
            int userChoiceInt;
            int userInputInt;

            do
            {

                do
                {
                    Console.WriteLine("Enter a value: ");
                    userInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(userInput))
                    {
                        Console.WriteLine("Name can't be empty! Input your name once more.");
                    }
                    else
                    {
                        userInputEmpty = false;
                    }
                } while (userInputEmpty == true);

                do
                {
                    Console.WriteLine("Select the Data type to validate the input you have entered.\nPress 1 for String.\nPress 2 for Integer.\nPress 3 for Boolean.");
                    userChoiceString = Console.ReadLine();
                    if (int.TryParse(userChoiceString, out userChoiceInt))
                    {
                        userChoiceInt = int.Parse(userChoiceString);
                        userChoiceValid = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please enter 1, 2, or 3.");
                        userChoiceValid = false;
                    }
                } while (userChoiceValid == false);


                Console.WriteLine("\nYou have entered a value: {0}.", userInput);

                switch (userChoiceInt)
                {
                    case 1:
                        //String
                        if (IsAllAlphabetic(userInput) == true)
                        {
                            Console.WriteLine("It is a valid: String.");
                        }
                        else
                        {
                            Console.WriteLine("It is an invalid: String.");
                        }
                        break;

                    case 2:
                        //Integer
                        if (int.TryParse(userInput, out userInputInt))
                        {
                            Console.WriteLine("It is a valid: Integer.");
                        }
                        else
                        {
                            Console.WriteLine("It is an invalid: Integer.");
                        }
                        break;

                    case 3:
                        //Boolean
                        userInput = userInput.ToLower();
                        if (userInput == "true" || userInput == "false")
                        {
                            Console.WriteLine("It is a valid: Boolean.");
                        }
                        else
                        {
                            Console.WriteLine("It is an invalid: Boolean.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }

                Console.WriteLine("\n\n\nClick Enter to run again or type any value to exit.");
                runAgainAnswer = Console.ReadLine();

                if (String.IsNullOrEmpty(runAgainAnswer))
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }

            } while (runAgain == true);
        }

        static bool IsAllAlphabetic(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }

            return true;
        }
    }
 
/*
Create an application that takes 2 input values.

Any input value (1st input)

Asks the data type of the input value. (2nd input)

It will print to the console the options like below to take input for the 2nd input value:

Press 1 for String

Press 2 for integer

Press 3 for Boolean

If the input value for the 2nd input is 1 then the application should check that if the entered 1st input is a valid string or not. Hereby we even want to check, if it is a complete alphabetic entry (so no numbers accepted)

If the input value for the 2nd input is 2 then the application should check if the entered 1st input is a valid integer or not.

Based on the input the 1st value and the selection of data type using the 2nd input, the application should return whether the entered 1st value is of data type selected by the user or not.

Please make sure to use a switch statement. To check the valid string you can write your custom logic.

For example:

Enter a value: {here you can enter any value}

Select the Data type to validate the input you have entered.

Press 1 for String

Press 2 for Integer

Press 3 for Boolean

Here, if you enter 1 it should return below message

You have entered a value: Denis Panjuta

It is a valid: String

Here, if you enter 2 it should return below message

You have entered a value: Denis Panjuta

It is an invalid: Integer
*/
}
