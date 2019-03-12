using System;
using System.Collections.Generic;
/*

Table students {
Id int PK
CohortId int
FirstName string
LastName string
SlackHandle string
Exercises list
}

*/
namespace student_exercises
{
    /*
    Defining my student class with relevant and unique data types. This results
    in a custom object. Each instance of the student class will all have values
    for the properties outlined below.
    */
    public class Student
    {
        public int studentId { get; set; }
        public int cohortId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slackHandle { get; set; }

        public List<Exercise> exerciseList { get; set; }

      // Constructor setup. Leave out the list as an arg
      public Student(int newStudentId,int newCohortId, string newFirstName, string newLastName, string newSlackHandle)
        {
          studentId = newStudentId;
          cohortId = newCohortId;
          firstName = newFirstName;
          lastName = newLastName;
          slackHandle = newSlackHandle;
          exerciseList = new List<Exercise>();
        }
    }
}