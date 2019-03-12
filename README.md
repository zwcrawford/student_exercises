# student_exercises, .NET Core command line project

ERD:

Table students {
  Id int PK
  CohortId int
  FirstName string
  LastName string
  SlackHandle string
  Exercises list
}

Table cohorts {
  Id int PK
  InstructorId int
  Name string
  StudentCount int
  InstructorCount int
}

Table instructors {
  Id int PK
  FirstName string
  LastName string
  SlackHandle string
  CohortId int
  AddExercise method()
}

Table exercises {
  Id int PK
  full_name string
  exercise_lang string
}

Table StudentExercises {
  Id int PK
  studentId int
  exerciseId int
}