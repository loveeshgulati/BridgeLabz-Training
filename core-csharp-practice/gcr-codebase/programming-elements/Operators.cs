using System;
class Operators{
	static void Main(String[] args){
	int a =10;
	int b =5;
	//Arithmetic Operators
	Console.WriteLine("Addition : " + (a+b));
	Console.WriteLine("Substraction : " + (a-b));
	Console.WriteLine("Division : " + (a/b));
	Console.WriteLine("Multiplication : " + (a*b));
	Console.WriteLine("Modulus : " + (a%b));
	//Relational Operators
	Console.WriteLine("a == b: " + (a == b)); 
	Console.WriteLine("a != b: " + (a != b)); 
	Console.WriteLine("a > b: " + (a > b)); 
	Console.WriteLine("a < b: " + (a < b)); 
	Console.WriteLine("a >= b: " + (a >= b));
	Console.WriteLine("a <= b: " + (a <= b));
	//Logical Operators
	bool z = true;
	bool y = false;
	Console.WriteLine("Logical AND: " + (z && y)); 
	Console.WriteLine("Logical OR: " + (z || y)); 
	Console.WriteLine(" Logical NOT: " + (!z));
	//Assignment Operators
	a+=b;
	Console.WriteLine("a+=b :"+a);
	a-=b;
	Console.WriteLine("a-=b :"+a);
	a*=b;
	Console.WriteLine("a*=b :"+a);
	a/=b;
	Console.WriteLine("a/=b :"+a);
	a%=b;
	Console.WriteLine("a%=b :"+a);
	//Unary Operators
	Console.WriteLine("a: " + a); 
	Console.WriteLine("++a: " + ++a); 
	Console.WriteLine("a++: " + --a); 
	Console.WriteLine("a: " + a);
	//Ternary Operators
	int max = (a>b)?a:b;
	Console.WriteLine("Max: " + max);
	//IS operator

			Vehicle myVehicle = new Car();
			Car myCar = new Car();
        
			Console.WriteLine("myVehicle is Vehicle: " + (myVehicle is Vehicle));
			Console.WriteLine("myVehicle is Car: " + (myVehicle is Car));
			Console.WriteLine("myVehicle is Bike: " + (myVehicle is Bike));
			Console.WriteLine("myCar is Vehicle: " + (myCar is Vehicle));
        
		
	}
}
//IS operator Classes
class Vehicle { }
class Car : Vehicle { }
class Bike : Vehicle { }