 using System;
 class PrimeNumber {
    static void Main(string[] args) {
      Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        for(int i=2;i<number;i++){
			
            if(number%i==0){
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime);
    }
}
