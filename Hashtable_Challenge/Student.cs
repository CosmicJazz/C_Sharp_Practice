using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hashtable_Challenge
{
    class Student
    {
        //Property called ID
        public int ID { get; set; }

        //Property called Name
        public string Name { get; set; }

        //Property called GPA
        public float GPA { get; set; }

        //Simple constructor
        public Student(int id, string name, float gpa)
        {
            this.ID = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
