using System;
using System.Collections.Generic;

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
		public string name { get; set; }
		public List<Student> studentCount { get; set; }
		public List<Instructor> instructorCount { get; set; }

		public Cohort(int newId, string newName)
		{
			id = newId;
			name = newName;
			studentCount = new List<Student>();
			instructorCount = new List<Instructor>();
		}
	}
}