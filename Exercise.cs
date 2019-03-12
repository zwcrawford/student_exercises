using System;

namespace student_exercises
{
    public class Exercise
    {
        public int exerciseId { get; set; }
        public string exerciseName { get; set; }
        public string exerciseLanguage { get; set; }

        public Exercise (int newExerciseId, string newExerciseName, string newExerciseLanguage) {
            exerciseId = newExerciseId;
            exerciseName = newExerciseName;
            exerciseLanguage = newExerciseLanguage;
        }
    }
}