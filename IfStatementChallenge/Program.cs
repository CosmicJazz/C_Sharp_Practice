using System;

namespace IfStatementChallenge
{
    class program
    {
        static void Main(string[] args)
        {

            string playerName;
            int playerScore;

            Console.WriteLine("What is the player's name?");
            playerName = Console.ReadLine();
            Console.WriteLine("What is the player's score?");
            playerScore = int.Parse(Console.ReadLine());

            CompareHighScores(playerName, playerScore);
            
            static void CompareHighScores(string playerName, int playerScore)
            {
                string highScoreName = "Denis";
                int highScore = 300;

                if(playerScore > highScore)
                {
                    Console.WriteLine("New highscore is " + playerScore + " set by " + playerName + "!");
                    Console.WriteLine("Previous highscore was " + highScore + " set by " + highScoreName + ".");
                    Console.WriteLine(playerName + " beat the previous highscore by " + (playerScore - highScore) + " points!");
                }
                else
                {
                    Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highScoreName + ".");
                }
            }
        }
    }
    //class Program
    //{

    //    static string username;
    //    static string password;

    //    static void Main(string[] args)
    //    {
    //        Register();
    //        Login();
    //    }

    //    public static void Register()
    //    {
    //        Console.WriteLine("Please enter your username.");
    //        username = Console.ReadLine();
    //        Console.WriteLine("Please enter your password.");
    //        password = Console.ReadLine();
    //        Console.WriteLine("Registration completed!");
    //        Console.WriteLine("--------------------------------------------------");
    //    }

    //    public static void Login()
    //    {
    //        Console.WriteLine("Please enter your username.");
    //        if (username == Console.ReadLine())
    //        {
    //            Console.WriteLine("Please enter your password.");
    //            if (password == Console.ReadLine())
    //            {
    //                Console.WriteLine("Login successful!");
    //            }
    //            else
    //            {
    //                Console.WriteLine("password failed! Restarting Program");
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Incorrect username, restarting Program");
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
