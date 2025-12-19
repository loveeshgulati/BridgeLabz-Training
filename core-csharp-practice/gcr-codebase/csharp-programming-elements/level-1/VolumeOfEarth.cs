using System;

public class VolumeOfEarth{ 
public static void Main(String[] args){
   
		double radiusInKm = 6378;  
        double volumeinKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusInKm, 3);
        double radiusInMiles = radiusInKm * 0.621371;
        double volumeinMiles = (4.0 / 3.0) * Math.PI * Math.Pow(radiusInMiles, 3);
		
        Console.WriteLine("The volume of earth in cubic kilometers is "+  volumeinKm +" and in Miles  " + volumeinMiles);
    }
}