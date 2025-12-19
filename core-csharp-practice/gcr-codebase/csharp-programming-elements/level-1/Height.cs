using System;
class Height{
    static void Main(){
        Console.Write("Enter your height in centimeters: ");
        double centimeters = Convert.ToDouble(Console.ReadLine());
        double totalInches = centimeters / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;
        Console.WriteLine(
            "Your Height in cm is " + centimeters +" while in feet is " + feet +" and inches is " + inches);
    }
}
