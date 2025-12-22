using System;
    class PowerOfNumber{   
        static void Main(string[] args){ 
		 Console.Write("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());    //Enter a number
         Console.Write("Enter a power");
            int power = Convert.ToInt32(Console.ReadLine());   // Enter a power			
            int res = 1;			
            for (int i =1;i<=power;i++){
             // calculating result
             res = res*n;
  }
           Console.WriteLine("Result: " + res);
     }
}