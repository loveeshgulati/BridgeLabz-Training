using System;
class GreatestFactor{
   static void Main(string[] args){
        // input user	
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int greatestFactor = 1; 
       // for loop
	   
        for (int i = num - 1; i >= 1; i--){     
            if (num % i == 0){
                greatestFactor = i;
                break;  
            }
        }
        Console.WriteLine("The greatest factor is: " + greatestFactor);
    }
}