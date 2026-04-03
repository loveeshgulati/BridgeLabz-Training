using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FitTrack
{
    abstract class Workout : ITrackable
    {
        public string WorkoutName { get; protected set; }
        public int DurationInMinutes { get; protected set; }

        protected Workout(string workoutName, int durationInMinutes)
        {
            WorkoutName = workoutName;
            DurationInMinutes = durationInMinutes;
        }

        public abstract void TrackWorkout();
        public abstract int CalculateCaloriesBurned();
    }
}
