using System;

namespace student_exercises
{
  public class Instructor
	{
		public int id { get; set; }
		public int cohortId { get; set; }
		public string firstName { get; set; }

		public string lastName { get; set; }

		public string slackHandle { get; set; }

		public void assignExercises (Student student, Exercise exercise) {
			student.exerciseList.Add(exercise);
		}
		public Instructor(int newId, int newCohortId, string newFirstName, string newLastName, string newSlackHandle)
		{
			id = newId;
			cohortId = newCohortId;
			firstName = newFirstName;
			lastName = newLastName;
			slackHandle = newSlackHandle;
		}
	}
}