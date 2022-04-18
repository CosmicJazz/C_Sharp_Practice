using System;

namespace Challenge_Loops_1_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            AverageLoopChallenge();
        }

        public static void AverageLoopChallenge()
        {

            int loopCount = 0;
            int totalScore = 0;
            int enteredNumberInt;
            string enteredNumberString;
            bool stillRun = true;

            do
            {
                Console.WriteLine("Please enter the student's score.");
                enteredNumberString = Console.ReadLine();

                bool userEnteredANumber = int.TryParse(enteredNumberString, out int number);
                if (userEnteredANumber)
                {
                    enteredNumberInt = number;

                    if (enteredNumberInt < 0)
                    {
                        Console.WriteLine("You entered a number less than 0, progeam will exit.");
                        stillRun = false;
                        enteredNumberInt = 0;
                        loopCount--;
                    }
                    if (enteredNumberInt > 20)
                    {
                        Console.WriteLine("You entered: {0}. The score entered should be between 0 - 21.",enteredNumberInt);
                        enteredNumberInt = 0;
                        if (loopCount > 0)
                        {
                            loopCount--;
                        }
                        else
                        {
                            loopCount = 0;
                        }
                    }
                    loopCount++;
                    totalScore = totalScore + enteredNumberInt;
                    Console.WriteLine("Your current average is: {0}. The number of scores enterd so far are: {1}", (totalScore / loopCount), loopCount);
                }
                else
                {
                    Console.WriteLine("No number was given, please enter a vailed intiger between 0 - 20.");
                }

                //DEBUG
                //Console.WriteLine("DEBUG: enteredNumberInt = {0}", enteredNumberInt);
                //Console.WriteLine("DEBUG: totalScore = {0}", totalScore);
                //Console.WriteLine("DEBUG: stillRun = {0}", stillRun);
                //Console.WriteLine("DEBUG: loopCount = {0}", loopCount);

            } while (stillRun);
            Console.WriteLine("Program is now exiting.");
            Console.Read();
        }
    }
}
