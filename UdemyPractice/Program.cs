using System;

namespace UdemyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ifStatments();
            //nestedIfStatements();
            //SwitchCase();
            //EnhancedIfStatement();
            //ForLoop();
            //DoWhileLoop();
            //WhileLoop();
            //BreakAndContinue();
        }

        public static void ifStatments()
        {
            Console.WriteLine("==If Statement & TryParse==");
            Console.WriteLine("Please enter the current temperature in Celcius");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            bool userEnteredANumber = int.TryParse(temperature, out number);

            if (userEnteredANumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("No number was given, passing 0.");
            }

            //Debugging
            Console.WriteLine("DEBUG: temperature = {0}", temperature);
            Console.WriteLine("DEBUG: userEnteredANumber = {0}", userEnteredANumber);
            Console.WriteLine("DEBUG: number = {0}", number);
            Console.WriteLine("DEBUG: numTemp = {0}", numTemp);

            if (numTemp < 20)
            {
                Console.WriteLine("Take Coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("It's 20 degreese C");
            }
            else if (numTemp > 30)
            {
                Console.WriteLine("It's super hot!");
            }
            else
            {
                Console.WriteLine("Cozy and warm!");
            }

            Console.Read();
        }

        public static void nestedIfStatements()
        {
            Console.WriteLine("==Nested If Statement==");
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your username.");
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user.");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, " + userName + ".");
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin!");
                    }
                }
            }

            if (isAdmin || isRegistered)
            {
                Console.WriteLine("You are loggedin.");
            }

            Console.ReadLine();
        }

        public static void SwitchCase()
        {
            //Similar to if statements, but with less logic.
            Console.WriteLine("==Switch and Case==");
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            string username = "Denis";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Username is Denis.");
                        break;
                case "root":
                    Console.WriteLine("Username is root.");
                    break;
                default:
                    Console.WriteLine("unknown username.");
                    break;
            }

            Console.Read();

        }

        public static void EnhancedIfStatement()
        {
            Console.WriteLine("==Enhanced If Statement==");
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquids";

            Console.WriteLine("The state of matter is {0}.", stateOfMatter);

            //Ehanced version
            temperature = 105;

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("The state of matter is {0}.", stateOfMatter);
            Console.Read();
        }

        public static void ForLoop()
        {
            Console.WriteLine("==For Loop==");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Itteration " + i);
                for (int j = 10; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
            }
            Console.Read();
        }

        public static void DoWhileLoop()
        {
            Console.WriteLine("==Do While Loop==");
            int i = 100;

            do
            {
                Console.WriteLine(i + " bottles of beer on the wall, " + i + " bottles of beer! \nTake one down, pass it around, " + (i - 1) + " bottles of beer on the wall!");
                i--;
            } while (i > 0);
        }

        public static void WhileLoop()
        {
            Console.WriteLine("==While Loop==");
            int i = 0;
            string enteredText = "";
            Console.WriteLine("Please press enter to increase ammount by 1. Click anything else to cancle.");

            while (enteredText.Equals(""))
            {
                enteredText = Console.ReadLine();
                i++;
                Console.WriteLine("Current count is: {0}", i);
            }
            Console.WriteLine("Final count: {0}", i);
        }

        public static void BreakAndContinue()
        {
            Console.WriteLine("==Break and Continue==");

            for(int i = 0; i<10; i++)
            {

                if (i == 3)
                {
                    Console.WriteLine("At 3 we continue! Code will continue here");
                    continue;
                }

                Console.WriteLine(i);
                if(i == 7)
                {
                    Console.WriteLine("At 7 we stop! Code will break here");
                    break;
                }
            }
            Console.Read();

        }
    }    
}
