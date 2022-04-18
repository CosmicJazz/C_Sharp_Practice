using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Class_Members
{
    class Members
    {
        //Member - private fields.
        private string memberName;
        private string jobTitle;
        private int salary;

        //Member - private fields.
        public int age;

        //Member - Propority (This one exposes jobTitle safely) - Properties start with a capital letter.
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member method - can be called from other classes.
        public void Introduceing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I am {2} years old.", memberName, jobTitle, age);
            }
        }

        //private member method - is accessed through other methods.
        private void SharingPrivateInfo()
        {
            Console.WriteLine("It is good to see you my trusted friend. My salary is {0}", salary);
        }

        //Member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //Member - Finalizer/Destructor.
        //Is triggered of member runs out of scope. ie. when Main() is completed.
        //If there is no reason to have a Finalizer, do not create one.  An entry is created in the fnalizing queue that is ran at every garbage collection and can use up performance.
        ~Members()
        {
            //Cleanup statements
            Console.WriteLine("Destruction of Members object.");
            Debug.Write("Destruction of Member object.");
        }
    }
}
