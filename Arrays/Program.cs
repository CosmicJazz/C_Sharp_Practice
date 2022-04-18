using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize array
            int[] grades = new int[5];

            //Manually populate array
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 7;

            Console.WriteLine("grades at index 0 = {0}", grades[0]);

            Console.WriteLine("Please input a new value for grades at index 0.");
            string input = Console.ReadLine();
            //Assign value to array graes at index 0
            grades[0] = int.Parse(input);
            Console.WriteLine("grades at index 0 = {0}", grades[0]);

            //Another Initializing method
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //Another Initializing method
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 15 };

            //Console.WriteLine(gradesOfMathStudentsA);

            Console.WriteLine("The length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);
        }
    }
}
