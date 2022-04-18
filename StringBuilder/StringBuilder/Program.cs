using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] favNums = new int[3];

            favNums[0] = 23;

            Console.WriteLine("FavNum 0 : {0}", favNums[0]);

            string[] customers = { "bob", "sally", "Sue" };

            var employees = new[] { "mike", "Paul", "Rick" };

            object[] randomArray = { "Paul", 56, 1.234 };

            Console.WriteLine("RandomArray 0 : {0}", randomArray[2].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array : {0} Value : {1}", i, randomArray[i]);
            }

            string[,] custNames = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Mark" } };

            Console.WriteLine("MD value : {0}", custNames.GetValue(1,1));

            for (int i = 0; i < custNames.GetLength(0); i++)
            {
                for (int j = 0; j < custNames.GetLength(1); j++)
                {
                    Console.Write("{0} ", custNames[i,j]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 9, 2 };

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0},", Array.IndexOf(randNums, 1));

            randNums.SetValue(0, 1);

            PrintArray(randNums, "ForEach");

            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, destArray, startInd, length);

            PrintArray(destArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10);

            srcArray.CopyTo(anotherArray, 5);

            foreach(int m in anotherArray)
            {
                Console.WriteLine("CopyTo : {0}", m);
            }

            int[] numArray = { 1, 11, 22 };

            Console.WriteLine(">10 : {0}", Array.Find(numArray, GT10));

            Console.ReadLine();
        }

        static void PrintArray(int[] intArray, string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        private static bool GT10(int val)
        {
            return val > 10;
        }
    }
}
