using System;

namespace Array_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            Console.WriteLine("For Loop");
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Index {0} = {1}", j, nums[j]);
            }

            Console.WriteLine("\nFor Each Loop");
            int counter = 0;
            foreach(int k in nums)
            {
                Console.WriteLine("Index {0} = {1}", counter, k);
                counter++;
            }

            //Create an array with 5 of your best friends
            //Create a foreach loop wich greets all of them

            string[] bestFriends = new string[5];
            counter = 0;

            foreach (string name in bestFriends)
            {
                Console.WriteLine("\nPlease write out the name of your best friend. [{0}/5]", counter);
                bestFriends[counter] = Console.ReadLine();
                counter++;
            }

            Console.WriteLine("\nI will now print out the names of your friends in an array.");

            counter = 0;
            foreach (string name in bestFriends)
            {
                Console.WriteLine("Best Friend at Index {0} = {1}", counter, name);
                counter++;
            }
        }
    }
}
