using System;
class hello{
    public static void Main(string[] args){
        int [,] array1 = new int [3,3];
        int [,] array2 = new int [3,3];
        int [,] array3 = new int [3,3];

        Console.WriteLine("Enter matrix 1 of 3 x 3 ::");
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter matrix 2 of 3 x 3 ::");
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                array1[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix Addition is ::");
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                array3[i,j] = array1[i,j] + array2[i,j];
                // Console.Write(array3[i,j]+ " ");
            }
            // Console.WriteLine("");
        }
         for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                Console.Write(array3[i,j]+ " ");
            }
            Console.WriteLine("");
        }
    }
}