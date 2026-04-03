using System;
class MultipleOfNumber{
   static void Main(string[] args) {
	// taking input from user
        Console.Write("Enter a number: ");
         int n = Convert.ToInt32(Console.ReadLine());
		 
		for (int i = 100; i >= 1; i--){
			//if remainder is zero then it is the factor of number
		
     		if (i % n  == 0){
                Console.WriteLine(i);
            }
        }
    }
}