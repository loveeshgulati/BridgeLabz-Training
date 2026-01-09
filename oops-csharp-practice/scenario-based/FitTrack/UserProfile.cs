using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FitTrack
{
    class UserProfile
    {
        public string UserName { get; private set; }
        private List<Workout> workouts = new List<Workout>();

        public UserProfile(string userName)
        {
            UserName = userName;
        }

        public void AddWorkout(Workout workout)
        {
            workouts.Add(workout);
        }

        public void ShowWorkoutSummary()
        {
            Console.WriteLine($"Fitness Summary for {UserName}");

            foreach (Workout workout in workouts)
            {
                workout.TrackWorkout();
                Console.WriteLine($"Calories Burned: {workout.CalculateCaloriesBurned()}");
                Console.WriteLine();
            }
        }
    }
}
