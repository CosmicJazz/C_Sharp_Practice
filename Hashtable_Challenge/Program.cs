using System;
using System.Collections;

namespace Hashtable_Challenge
{

    //Challenge
    /*
     * Write a program that will itierate though each element of the students array and insert them into a hashtable.
     * If a student with the same ID already exists in the hashtable, skip it and display the following error:
     * "Sorry, a student with the same ID Already exists."
     * HINT: Use the method ContainsKey() to check whether a student with the same ID already exists.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentsHastable = new Hashtable();
            Student[] studentsArray = new Student[5];

            studentsArray[0] = new Student(1, "Denis", 88);
            studentsArray[1] = new Student(2, "Olaf", 97);
            studentsArray[2] = new Student(6, "Rganar", 65);
            studentsArray[3] = new Student(1, "Luise", 73);
            studentsArray[4] = new Student(4, "Levi", 58);

            foreach (Student student in studentsArray)
            {
                if (studentsHastable.ContainsKey(student.ID))
                {
                    Console.WriteLine("Sorry, a student with the same ID Already exists.");
                    //Console.WriteLine("Student ID #{0} is already being used by {1}", student.ID, student.Name);
                }
                else
                {
                    studentsHastable.Add(student.ID, student);
                }
                
            }


            foreach (Student student in studentsHastable.Values)
            {
                Console.WriteLine("Student ID: {0}", student.ID);
                Console.WriteLine("Student Name: {0}", student.Name);
                Console.WriteLine("Student GPA: {0}", student.GPA);
            }

        }
    }
}
