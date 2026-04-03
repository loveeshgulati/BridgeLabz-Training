using System;
class EmployeeBonus{
	static void Main(String[] args){
		Console.Write("Enter employee salary");
		//taking input
		double salary = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter years of service");
		double yearsOfService = Convert.ToDouble(Console.ReadLine());
		double bonus =0;
		if(yearsOfService > 5){
			bonus = salary * 0.05;
		}
		Console.WriteLine("The bonus amount is :" + bonus);
	}
}	