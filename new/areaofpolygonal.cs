using System;
class hello{
    public static void Main(string[] args){
        Console.WriteLine("ENTER APOTHEM AND PERIMETER OF POLYGON :: ");
        int a , p ;
        a = Convert.ToInt32(Console.ReadLine());
        p = Convert.ToInt32(Console.ReadLine());
        double area = 0.5 * a * p;
        Console.WriteLine("AREA OF POLYGON :: "+area);
    }
}
