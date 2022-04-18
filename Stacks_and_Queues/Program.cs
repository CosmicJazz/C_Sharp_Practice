using System;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACKS
            Console.WriteLine("HERE ARE ALL EXAMPLES OF USING STACKS");
            //defining a stack
            //only one data type per stack
            //stack elements are added from the top and removed from the top
            //FIFO
            Stack<int> stack = new Stack<int>();
            //cannot Pop() elements if the stack is empty, the program will crash
            if(stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("Stack is currently empty.");
            }

            //add elements to the stack using Push()
            stack.Push(1);
            stack.Push(1337);
            //Peek() will return the element at the top of the stack without remving it
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());
            //adding lots of items to give example of Peek()
            stack.Push(1);
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());
            stack.Push(3);
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());
            //removes item from stack
            int myStackItem = stack.Pop();
            Console.WriteLine("Poped last value.");
            Console.WriteLine("The top value in the stack is now: {0}", stack.Peek());
            Console.WriteLine("My stored value is: {0}", myStackItem);
            stack.Push(3);
            Console.WriteLine("The top value in the stack is: {0}", stack.Peek());

            //example or removing all items from a stack
            //when an item is poped, you can use it, but it will be removed
            while (stack.Count > 0)
            {
                Console.WriteLine("The top value {0} was removed from the stack.", stack.Pop());
                Console.WriteLine("Current stack count is: {0}", stack.Count);
            }

            //example of how to add an array of numbers to a stack
            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("\nMy new stack array of numbers are: ");
            foreach(int number in numbers)
            {
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("\nThose numbers in revers are: ");
            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop() + " ");
            }

            Console.WriteLine("\nThe array stack is now empty.");


            //QUEUES
            Console.WriteLine("\n\nHERE ARE ALL EXAMPLES OF USING QUEUES");
            //elements of a queue are added from the bottom and remvoed from the top
            //LIFO
            //defining a queue of integers
            Queue<int> queue = new Queue<int>();
            //to add at an element in the queue, use the Enqueue() method
            queue.Enqueue(1);
            //to look at an element in the queue, use the same Peek() method
            Console.WriteLine("The vlaue at the front of the queue is {0}", queue.Peek());
            queue.Enqueue(2);
            Console.WriteLine("The vlaue at the front of the queue is {0}", queue.Peek());
            queue.Enqueue(3);
            Console.WriteLine("The vlaue at the front of the queue is {0}", queue.Peek());
            int queuedItem = queue.Dequeue();
            Console.WriteLine("Dequeued first element int the queue: {0}", queuedItem);
            Console.WriteLine("The vlaue at the front of the queue is {0}", queue.Peek());

        }
    }
}
