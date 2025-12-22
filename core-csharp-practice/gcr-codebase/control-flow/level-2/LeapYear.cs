using System;
class LeapYear {
    static void Main(string[] args) {	
	    //taking input 
        Console.Write("Enter a Year");
        int year= Convert.ToInt32(Console.ReadLine());
        if(year > 1582){	
		
            if(year%4==0 && year%100!=0){
                Console.WriteLine("Leap year");
            }
			
			else if(year%400==0){
                Console.WriteLine("leap year");
            }
			
			else{
             Console.WriteLine("not a leap year");
            }
        }
    }
}
