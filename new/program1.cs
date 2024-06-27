using System;
namespace HelloWorld{
    class program{
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
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