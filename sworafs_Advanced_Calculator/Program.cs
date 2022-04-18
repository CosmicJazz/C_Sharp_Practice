using System;

namespace sworafs_Advanced_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMultiply = false;
            bool isAddition = false;
            bool isDivision = false;
            bool isSubtraction = false;
            Console.Write("Please input what you want to do: ");
            string equiation = Console.ReadLine();
            equiation = equiation.Trim();
            double value1 = 0;
            double value2 = 0;
            double answer;
            int i = 0;
            while (equiation.Length > i)
            {
                if (equiation.Substring(i, 1) == "*")
                {
                    value1 = Double.Parse(equiation.Substring(0, i));
                    value2 = Double.Parse(equiation.Substring(i + 1));
                    isMultiply = true;
                }
                else if (equiation.Substring(i, 1) == "/")
                {
                    value1 = Double.Parse(equiation.Substring(0, i));
                    value2 = Double.Parse(equiation.Substring(i + 1));
                    isDivision = true;
                }
                else if (equiation.Substring(i, 1) == "+")
                {
                    value1 = Double.Parse(equiation.Substring(0, i));
                    value2 = Double.Parse(equiation.Substring(i + 1));
                    isAddition = true;
                }
                else if (equiation.Substring(i, 1) == "-")
                {
                    value1 = Double.Parse(equiation.Substring(0, i));
                    value2 = Double.Parse(equiation.Substring(i + 1));
                    isSubtraction = true;
                }
                i++;
            }
            if (isMultiply == true)
            {
                answer = value1 * value2;
                Console.WriteLine(value1 + " * " + value2 + " = " + answer);
            }
            else if (isDivision == true)
            {
                answer = value1 / value2;
                Console.WriteLine(value1 + " / " + value2 + " = " + answer);
            }
            else if (isAddition == true)
            {
                answer = value1 + value2;
                Console.WriteLine(value1 + " + " + value2 + " = " + answer);
            }
            else if (isSubtraction == true)
            {
                answer = value1 - value2;
                Console.WriteLine(value1 + " - " + value2 + " = " + answer);
            }
            else
            {
                Console.WriteLine("You are pretty stupid if you did not follow my instructions\nI reccomend you to restart (although you have no choice)");
            }
            Console.ReadKey();
        }
    }
}
