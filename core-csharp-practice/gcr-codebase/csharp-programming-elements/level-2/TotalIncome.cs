using System;
class TotalIncome{
    static void Main(string[] args){
        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        double income = salary + bonus;

        Console.WriteLine("The salary is INR " + salary +" and bonus is INR " + bonus +". Hence Total Income is INR " + income);
    }
}
