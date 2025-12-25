using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class OTPGenerator
    {
        // a. Generate a 6-digit OTP
        static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000); // 6-digit number
        }

        // c. Check whether all OTPs are unique
        static bool AreOTPsUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }

        static void Main(string[] args)
        {
            // b. Array to store 10 OTPs
            int[] otpList = new int[10];

            // Generate OTPs
            for (int i = 0; i < otpList.Length; i++)
            {
                otpList[i] = GenerateOTP();
            }

            Console.WriteLine("Generated OTPs:");
            for (int i = 0; i < otpList.Length; i++)
            {
                Console.WriteLine("OTP " + (i + 1) + ": " + otpList[i]);
            }

            Console.WriteLine();

            // Check uniqueness
            bool isUnique = AreOTPsUnique(otpList);

            if (isUnique)
            {
                Console.WriteLine("All generated OTPs are unique.");
            }
            else
            {
                Console.WriteLine("Duplicate OTPs found.");
            }
        }
    }
}
