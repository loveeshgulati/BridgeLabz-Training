using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FitTrack
{
    class StrengthWorkout : Workout
    {
        public int TotalReps { get; private set; }

        public StrengthWorkout(string name, int duration, int reps)
            : base(name, duration)
        {
            TotalReps = reps;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine($"Strength Workout: {WorkoutName}");
            Console.WriteLine($"Duration: {DurationInMinutes} mins, Reps: {TotalReps}");
        }

        public override int CalculateCaloriesBurned()
        {
            return DurationInMinutes * 6; 
        }
    }
}
