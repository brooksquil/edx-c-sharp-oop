using System;
using System.Collections.Generic;

namespace exercise
{
    // Declaring the Student() class
    public class Student
    {
        //Defining properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string studentID { get; set; }

        // create integer variable called instances and assigns value to 0
        private static int instances = 0;

        // constructor to increment student count
        public Student()
        {
            //every time constructir runs increment instances variable
            instances++;
        }

        //static class to track students enrolled when student object created
        public static int CountCars()
        {
            return instances;
        }
    }

    
}