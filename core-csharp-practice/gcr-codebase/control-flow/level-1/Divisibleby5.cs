using System;
class Divisibleby5 {
	static void Main(String[] args){
		Console.Write("Enter the number :");
		int number = Convert.ToInt32(Console.ReadLine());
		if( number % 5 == 0){
			Console.WriteLine("Is the number "+number+" divisible by 5? Yes");
		}
		else{
			Console.WriteLine("Is the number "+number+" divisible by 5? No");
		}
	}
}