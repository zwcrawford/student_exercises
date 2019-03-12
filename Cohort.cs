using System;

/*

Table cohorts {
  Id int PK
  InstructorId int
  Name string
  StudentCount int
  InstructorCount int
}

*/
namespace student_exercises
{
	/*
    Defining my cohort class with relevant and unique data types. This results
    in a custom object. Each instance of the cohort class will all have values
    for the properties outlined below.
    */
	public class Cohort
	{
		public int id { get; set; }
		public int instructorId { get; set; }
		public string name { get; set; }
		public int studentCount { get; set; }
		public int instructorCount { get; set; }

		public Cohort(int newId, int newInstructorId, string newName, int newStudentCount, int newInstructorCount)
		{
			id = newId;
			instructorId = newInstructorId;
			name = newName;
			studentCount = newStudentCount;
			instructorCount = newInstructorCount;
		}
	}
}