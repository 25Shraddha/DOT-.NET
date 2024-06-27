using System;
public class hello{
    public static void Main(string[] args){
        Console.WriteLine("Enter Principal , Rate & Time :: ");
        double Principal , Rate , Time ;
        Principal = Convert.ToDouble(Console.ReadLine());
        Rate = Convert.ToDouble(Console.ReadLine());
        Time = Convert.ToDouble(Console.ReadLine());


        double simple_interest = (Principal * Rate * Time) / 100;
        Console.WriteLine("Simpleinterest: " + simple_interest);

    }
}