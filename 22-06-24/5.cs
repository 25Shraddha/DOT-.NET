using System;
class hello{
    public static void Main(string[] args){
        Console.WriteLine("Enter matrix elements : ");
        int [,] matrix = new int [3,3];
        for(int i =0;i<3;i++){
            for(int j =0;j<3;j++){
                matrix[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix is : ");
        for(int i =0;i<3;i++){
            for(int j =0;j<3;j++){
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

        int small = matrix[0,0]; 
        for(int i =0;i<3;i++){
            for(int j =0;j<3;j++){
                if(small > matrix[i,j]){  
                    small = matrix[i,j];  
                }
            }
        }
        Console.WriteLine("Smallest element of matrix is : " + small);

    }
}