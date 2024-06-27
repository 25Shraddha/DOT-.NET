using System;
class Program
{
    static void Main(string[] args)
    {
        // FIVE INTEGERS
        int num1 = 10 ; 
        object obj1 = num1 ;
        int num2 = 20 ;
        object obj2 = num2 ;
        int num3 = 30 ;
        object obj3 = num3 ;
        int num4 = 40 ;
        object obj4 = num4 ;
        int num5 = 50 ;
        object obj5 = num5 ;

        Console.WriteLine("1 :: " + "Value-typed :: "+num1 + " Object-typed :: "+obj1);
        Console.WriteLine("2 :: " + "Value-typed :: "+num2 + " Object-typed :: "+obj2);
        Console.WriteLine("3 :: " + "Value-typed :: "+num3 + " Object-typed :: "+obj3);
        Console.WriteLine("4 :: " + "Value-typed :: "+num4 + " Object-typed :: "+obj4);
        Console.WriteLine("5 :: " + "Value-typed :: "+num5 + " Object-typed :: "+obj5);

        // UNBOXING
        object object1 = "SHRAVANI";
        string name1 = (string) object1 ;
        Console.WriteLine("1:: "+" Object-typed :: "+ object1 + " Valued-typed :: " + name1);
        object object2 = "SHRADDHA";
        string name2 = (string) object2 ;
        Console.WriteLine("2:: "+" Object-typed :: "+ object2 + " Valued-typed :: " + name2);

        int r = 1;
        object o = r;
        object obj = "SHRADDHA JAPE";
        string name = Convert.ToString(obj);
        Console.WriteLine("Roll NUMBER IS :: " + o);
        Console.WriteLine("NAME IS :: "+ name); 


        // // Example  of Boxing
        // int valueType = 123;      // Value type
        // object boxedValue = valueType;  // Boxing: Converting value type to object type

        // Console.WriteLine("Boxing:");
        // Console.WriteLine("Value type: " + valueType);
        // Console.WriteLine("Boxed value: " + boxedValue);

        // // Example of Unboxing
        // object obj = 456;         // Boxed value
        // int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        // Console.WriteLine("\nUnboxing:");
        // Console.WriteLine("Object type: " + obj);
        // Console.WriteLine("Unboxed value: " + unboxedValue);

        // // Another example with double
        // double doubleValue = 78.9; // Value type
        // object boxedDouble = doubleValue; // Boxing

        // Console.WriteLine("\nBoxing double:");
        // Console.WriteLine("Double value: " + doubleValue);
        // Console.WriteLine("Boxed double: " + boxedDouble);

        // double unboxedDouble = (double)boxedDouble; // Unboxing

        // Console.WriteLine("\nUnboxing double:");
        
        // Console.WriteLine("Object type: " + boxedDouble);
        // Console.WriteLine("Unboxed double: " + unboxedDouble);
    }
}