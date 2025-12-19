using System;

class PenPerStudent{ 
    static void Main(){
        int totalpen = 14; 
        int students = 3;
        int remainder =  totalpen % students;
        int penPerStudent = totalpen / students;
        Console.WriteLine("The pen per student is " + penPerStudent + " and the remaining pen not distributed is " + remainder);
    }
}