using System;
using System.Collections.Generic;
using System.Text;

namespace CGProject.Bridge
{
    public class CheckVote
    {
        static void Main(string[] args)
        {
            int[] ages = new int[10];
            for(int i =0;i< ages.Length; i++)
            {
                Console.Write("Enter Age of student "+(i+1)+" :");
                ages[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Voting Eligibility :");
            for(int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid Age");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The students with age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The students with age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}
