using System;

namespace student_exercises
{
	class Program
	{
		static void AssignInstructorsToCohort (Instructor instr, Cohort co) => co.instructorCount.Add(instr);

		static void AssignStudentsToCohort (Student stu, Cohort co) => co.studentCount.Add(stu);
		static void Main()
		{
			// 1. Create 4 exercises
			// Need to add exercises so they can be assigned to students.
			Exercise exercise_1 = new Exercise (1, "chess", "HTML");
			Exercise exercise_2 = new Exercise (2, "go", "JS");
			Exercise exercise_3 = new Exercise (3, "risk", "SQL");
			Exercise exercise_4 = new Exercise (4, "monopoly", "JS");
			Exercise exercise_5 = new Exercise (5, "gin rummy", "SQL");
			Exercise exercise_6 = new Exercise (6, "global thermonuclear war", "C Sharp");

			Console.WriteLine();    // Blank line

			// 2. Create 3 cohorts
			// Built the cohorts with the constructor in Cohort.cs.
			Cohort C29 = new Cohort(29, "Cohort 29");
			Cohort C30 = new Cohort(30, "Cohort 30");
			Cohort C31 = new Cohort(31, "Cohort 31");

			Console.WriteLine(C29.name);
			Console.WriteLine(C29.id.ToString());
			Console.WriteLine();    // Blank line
			Console.WriteLine(C30.name);
			Console.WriteLine(C30.id.ToString());
			Console.WriteLine();    // Blank line
			Console.WriteLine(C31.name);
			Console.WriteLine(C31.id.ToString());

			// Create 4 students and assign them to one of the cohorts
			// Now use the new constructor for the other students
			Student Gabs = new Student(2, 29, "Gabs", "Crawford", "cheer_1");
			Student Tay = new Student(2, 29, "Taylor", "Rausch", "cheer_love");
			Student Caroline = new Student(2, 30, "Caroline", "Reynolds", "flyer1");
			Student Olivia = new Student(2, 31, "Olivia", "Meyers", "sup_dog");

			// Create 3 instructors and assign them to one of the cohorts.
			Instructor instructor_1 = new Instructor (1, 29, "Jisie", "David", "jdavid");
			Instructor instructor_2 = new Instructor (2, 30, "Andy", "Collins", "acollins");
			Instructor instructor_3 = new Instructor (3, 31, "Leah", "Gwin", "lgwin");

			// Assign instructors to cohorts
			AssignInstructorsToCohort(instructor_1, C29);
			AssignInstructorsToCohort(instructor_2, C30);
			AssignInstructorsToCohort(instructor_3, C31);

			// Assign students to cohort
			AssignStudentsToCohort(Gabs, C29);
			AssignStudentsToCohort(Tay, C29);
			AssignStudentsToCohort(Caroline, C30);
			AssignStudentsToCohort(Olivia, C31);

			// Instructors assign students to exercises

			// Jisie assigns exercises 1 and 2 for all students
			instructor_1.assignExercises(Gabs, exercise_1);
			instructor_1.assignExercises(Gabs, exercise_2);
			instructor_1.assignExercises(Tay, exercise_1);
			instructor_1.assignExercises(Tay, exercise_2);
			instructor_1.assignExercises(Caroline, exercise_1);
			instructor_1.assignExercises(Caroline, exercise_2);
			instructor_1.assignExercises(Olivia, exercise_1);
			instructor_1.assignExercises(Olivia, exercise_2);

			// Andy assigns exercises 3 and 4 for all students
			instructor_2.assignExercises(Gabs, exercise_3);
			instructor_2.assignExercises(Gabs, exercise_4);
			instructor_2.assignExercises(Tay, exercise_3);
			instructor_2.assignExercises(Tay, exercise_4);
			instructor_2.assignExercises(Caroline, exercise_3);
			instructor_2.assignExercises(Caroline, exercise_4);
			instructor_2.assignExercises(Olivia, exercise_3);
			instructor_2.assignExercises(Olivia, exercise_4);

			// Andy assigns exercises 5 and 6 for all students
			instructor_2.assignExercises(Gabs, exercise_5);
			instructor_2.assignExercises(Gabs, exercise_6);
			instructor_2.assignExercises(Tay, exercise_5);
			instructor_2.assignExercises(Tay, exercise_6);
			instructor_2.assignExercises(Caroline, exercise_5);
			instructor_2.assignExercises(Caroline, exercise_6);
			instructor_2.assignExercises(Olivia, exercise_5);
			instructor_2.assignExercises(Olivia, exercise_6);


		}
	}
}