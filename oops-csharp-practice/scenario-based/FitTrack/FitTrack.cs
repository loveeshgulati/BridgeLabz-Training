using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FitTrack
{
    class FitTrack
    {
        static void Main(string[] args)
        {
            UserProfile user = new UserProfile("Loveesh");
            Workout cardio = new CardioWorkout("Morning Run", 30, 5);
            Workout strength = new StrengthWorkout("Weight Training", 40, 120);

            user.AddWorkout(cardio);
            user.AddWorkout(strength);

            user.ShowWorkoutSummary();
        }
    }
}
