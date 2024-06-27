using System;
namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Program to check given number is even or odd");
            int number = 10;
            if(number %2==0){
                Console.WriteLine("EVEN NUMBER");
            }
            else{
                Console.WriteLine("ODD NUMBER");
            }
        }
    }
}