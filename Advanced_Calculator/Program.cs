using System;
using System.Data;


/* 
The order of operations is expressed here:

1. exponentiation and root extraction
2. multiplication and division
3. addition and subtraction

PEMDAS : Parentheses, Exponents, Multiplication/Division, Addition/Subtraction
*/

/*
 * HOW TO SOLVE EXAMPLE EQUATION
 * ((30-5)x10x4)/(9-(1.5+3.5+2)) = 500
 * 1. (30-5) = 25
 * (25x10x4)/(9-(1.5+3.5+2)) = 500
 * 2. 1.5+3.5+2 = 7
 * (25x10x4)/(9-7) = 500
 * 3. 25x10x4 = 1000
 * 1000/(9-7)
 * 4. 9-7 = 2
 * 1000/2
 * 5. 1000/2 = 500
 * */


namespace Advanced_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double expressionA;
            Double expressionB;
            Double solution = 0;
            int operatorIndex;
            int leftParenthesesIndex = 0;
            int rightParenthesesIndex = 0;
            String mathmaticEquationString;
            String smallMathEquation;
            String[] mathmaticEquationArray = new string[];
            Char characterCheck = ' ';
            Char arithmeticOperator = ' ';
 

            //Recieve matmaticEquation from user
            //((30-5)x10x4)/(9-(1.5+3.5+2)) = 500
            mathmaticEquationString = "((30-5)x10x4)/(9-(1.5+3.5+2))";
            mathmaticEquationString = mathmaticEquationString.Trim();

            foreach (char element in mathmaticEquationString) //What to do about negatives???
            {
                //If is digit OR '.'
                if (Char.IsDigit(element) || element == '.')
                {
                    //then look for next non-digit char
                    //when next non-digit char is found, use the index of cardinal digit char and new index char to assign the full digit
                    //ie (45.25+2) should assign arrays as {"(", "45.25", "+", "2", ")"}
                }
                //else add char to array
                else
                {
                    mathmaticEquationArray.Add(element);
                }
            }


            //do
            //{
            //Check through each char for '('
                leftParenthesesIndex = LeftmostParentheses(mathmaticEquationString, characterCheck, leftParenthesesIndex);
                //Console.WriteLine($"DEBUG: leftParenthesesIndex = {leftParenthesesIndex}");

                //Find index of next ')'
                rightParenthesesIndex = RightmostParentheses(leftParenthesesIndex, mathmaticEquationString, characterCheck, rightParenthesesIndex);
                //Console.WriteLine($"DEBUG: rightParenthesesIndex = {rightParenthesesIndex}");

                //Use mathmaticEquationString.Substring(leftParenthesesIndex, rightParenthesesIndex) to pull small expression out
                smallMathEquation = mathmaticEquationString.Substring(leftParenthesesIndex + 1, rightParenthesesIndex - leftParenthesesIndex - 1);
                Console.WriteLine($"Debug: Small equation = {mathmaticEquationString.Substring(leftParenthesesIndex + 1, rightParenthesesIndex - leftParenthesesIndex - 1)}");

                //Find arithmeticOperator

                //Find expressionA

                //Find expressionB

                //solve small expression and insert solution back into mathmaticEquationString
                //THIS CODE IS 100% CHEATING (Need to come up with own solution) (Also may not work with negatives? Need to test.)
                DataTable dt = new DataTable();
                var v = dt.Compute(smallMathEquation, "");
                Console.WriteLine($"smallMathEquation = {v}");
                //SmallMathSolution(arithmeticOperator, expressionA, expressionB, solution);

                //Repeat While loop

                //when no more parentheses are present, solve expression.
            //} while (true);



        }

        static int LeftmostParentheses(string mathmaticEquationString, char characterCheck, int leftParenthesesIndex)
        {
            for (int i = mathmaticEquationString.Length - 1; i >= 0; i--)
            {
                characterCheck = mathmaticEquationString[i];
                if (characterCheck == '(')
                {
                    //Find index of last '('
                    leftParenthesesIndex = i;
                    Console.WriteLine($"DEBUG: there is a LEFT parentheses at index {leftParenthesesIndex}");
                    break;
                }
            }
            return leftParenthesesIndex;
        }

        static int RightmostParentheses(int leftParenthesesIndex, string mathmaticEquationString, char characterCheck, int rightParenthesesIndex)
        {
            for (int i = leftParenthesesIndex; i <= mathmaticEquationString.Length; i++)
            {
                characterCheck = mathmaticEquationString[i];
                if (characterCheck == ')')
                {
                    //Find index of next ')'
                    rightParenthesesIndex = i;
                    Console.WriteLine($"DEBUG: there is a RIGHT parentheses at index {rightParenthesesIndex}");
                    break;
                }
            }
            return rightParenthesesIndex;
        }

        static double SmallMathSolution(char arithmeticOperator, Double expressionA, Double expressionB, Double solution)
        {
            //Switch Case for Operations
            switch (arithmeticOperator)
            {
                case '+':
                    Console.WriteLine("This is an addition operator.");
                    solution = expressionA + expressionB;
                    Console.WriteLine($"{expressionA} + {expressionB} = {solution}");
                    break;

                case '-':
                    Console.WriteLine("This is a subtraction operator.");
                    solution = expressionA - expressionB;
                    Console.WriteLine($"{expressionA} - {expressionB} = {solution}");
                    break;

                case '*':
                    Console.WriteLine("This is a multiplication operator.");
                    solution = expressionA* expressionB;
                    Console.WriteLine($"{expressionA} x {expressionB} = {solution}");
                    break;

                case '/':
                    Console.WriteLine("This is a division operator.");
                    solution = expressionA / expressionB;
                    Console.WriteLine($"{expressionA} / {expressionB} = {solution}");
                    break;

                default:
                    Console.WriteLine($"DEBUG: {arithmeticOperator} is not a valid mathmatical operator...");
                    break;
            }
            return solution;
        }
            
}
}
