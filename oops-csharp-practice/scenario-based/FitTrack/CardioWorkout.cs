using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FitTrack
{
    class CardioWorkout : Workout
    {
        public int DistanceInKm { get; private set; }

        public CardioWorkout(string name, int duration, int distance)
            : base(name, duration)
        {
            DistanceInKm = distance;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine($"Cardio Workout: {WorkoutName}");
            Console.WriteLine($"Duration: {DurationInMinutes} mins, Distance: {DistanceInKm} km");
        }

        public override int CalculateCaloriesBurned()
        {
            return DurationInMinutes * 8; 
        }
    }
}
