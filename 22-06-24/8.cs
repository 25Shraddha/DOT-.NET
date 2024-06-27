using System;
public class hello{
    public static void Main(string[] args){
        Console.WriteLine("Enter Distance(Meters) and Time(Minutes) : ");
        int distance ; int time ;
        distance = Convert.ToInt32(Console.ReadLine());
        time = Convert.ToInt32(Console.ReadLine());
        float speed ;
        speed = distance/time;
        Console.WriteLine("Distance : "+distance + " Meters");
        Console.WriteLine("Time : "+time + " Seconds");
        Console.WriteLine("Speed : "+speed + " Meters/Minutes");
    }
}