using System;
public class SimpleInterestCalculator{
    static void Main(string[] args){
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Time: ");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The Simple Interest is " + simpleInterest +" for Principal " + principal +", Rate of Interest " + rate +" and Time " + time);
    }
}
