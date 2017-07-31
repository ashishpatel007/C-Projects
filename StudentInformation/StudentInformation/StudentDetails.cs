using System;
namespace StudentInformation
{
    public class StudentDetails
    {
        Student st = new Student("Ashish", "Patel", 3.9f);
        Student st2 = new Student(13, "Peter", "Griffin", 1.0f);

        public void displayOutput()
        {
            st.StudentID = 101;
            Console.WriteLine("{0} {1}'s GPA is {2:F2}", st.FirstName, st.LastName, st.GPA);
            Console.WriteLine("Pavol's ID is {0} ", st.StudentID);
            Console.WriteLine("Student's ID is {0}. {1} {2}'s GPA is {3:F2}", st2.StudentID, st2.FirstName, st2.LastName, st2.GPA);
        }
    }
}
