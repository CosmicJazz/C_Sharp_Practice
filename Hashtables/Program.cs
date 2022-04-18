using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        //[Key] - [Value]
        //Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.ID, stud1);
            studentsTable.Add(stud2.ID, stud2);
            studentsTable.Add(stud3.ID, stud3);
            studentsTable.Add(stud4.ID, stud4);

            //Retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[1];

            //Retrieve all values from a Hashtable
            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine("Student ID: {0}", student.ID);
                Console.WriteLine("Student Name: {0}", student.Name);
                Console.WriteLine("Student GPA: {0}", student.GPA);
            }
        }
    }
}
