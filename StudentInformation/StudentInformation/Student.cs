using System;
namespace StudentInformation
{
    public class Student
    {
        public Student(string firstName, string lastName, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            GPA = gpa;
            
        }

        public Student(int id, string firstName, string lastName, float gpa)
        {
            StudentID = id;
            FirstName = firstName;
			LastName = lastName;
			GPA = gpa;
        }

        // This is sorta like the interfaces in Java
        //setting properties
        public int StudentID { get; set; }      
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public float GPA { get; set; }
    }
}
