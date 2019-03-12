using System;

namespace student_exercises
{
	class Program
	{
		static void Main(string[] args)
		{
			// Leaving this in. ;)
			Console.WriteLine("Hello World!");

			Console.WriteLine();    // Blank line

			// 1. Create 4 exercises
			// Did so in the exerciseList but had to create a student first as the list is defined there.
			Student Sam = new Student();
			Sam.exerciseList.Add("exercise_1");
			Sam.exerciseList.Add("exercise_2");
			Sam.exerciseList.Add("exercise_3");
			Sam.exerciseList.Add("exercise_4");

			foreach (string ex in Sam.exerciseList) {
			Console.WriteLine(ex);
			}

			Console.WriteLine();    // Blank line

			// 2. Create 3 cohorts
			// Built the cohorts with the constructor in Cohort.cs.
			Cohort C29 = new Cohort(1, 29, "Cohort 29", 30, 5);
			Cohort C30 = new Cohort(2, 30, "Cohort 30", 40, 7);
			Cohort C31 = new Cohort(3, 31, "Cohort 31", 50, 9);

			Console.WriteLine(C29.name);
			Console.WriteLine(C29.id.ToString());

			Console.WriteLine();    // Blank line

			Console.WriteLine(C30.name);
			Console.WriteLine(C30.id.ToString());

			Console.WriteLine();    // Blank line

			Console.WriteLine(C31.name);
			Console.WriteLine(C31.id.ToString());
		}
	}
}
