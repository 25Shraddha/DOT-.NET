using System;
namespace program{
    class Program{
        static void Main(string[] args){

            int num1 , num2;
            Console.WriteLine("ENTER TWO NUMBERS :: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            // +=
            num1 += num2;
            Console.WriteLine("ADDITION OF THE TWO NUMBERS IS :: "+num1);
            // -=
            num1 -= num2;
            Console.WriteLine("SUBSTRACTION OF THE TWO NUMBERS IS :: "+num1);
            // *=
            num1 *= num2;
            Console.WriteLine("MULTIPLICATION OF THE TWO NUMBERS IS :: "+num1);
            // /=
            num1 /= num2;
            Console.WriteLine("DIVISION OF THE TWO NUMBERS IS :: "+num1);
            // %=
            num1 %= num2;
            Console.WriteLine("MODULUS OF THE TWO NUMBERS IS :: "+num1);




            // //ASSIGNMENT OPERATOR
            // int size ;
            // Console.WriteLine("ENTER SIZE OF THE ARRAY :: ");
            // size = Convert.ToInt32(Console.ReadLine());
            // int [] array = new int[size];

            // Console.WriteLine("ENTER ARRAY ELEMENTS :: ");
            // for(int i = 0 ; i < size ; i++){
            //     array[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // // Console.WriteLine("ARRAY ELEMENTS ARE :: ");
            // // for(int i = 0 ; i < size ; i++){
            // //     Console.WriteLine(array[i]);
            // // }
            // //ADDITION OF ARRAY ELEMENTS 
            // int sum = 0;
            // for(int i = 0 ; i < array.Length ; i++){
            //     sum += array[i];
            // }
            // Console.WriteLine("ADDITION OF ARRAY ELEMENTS IS :: " + sum);


            
            
        }
    }
}