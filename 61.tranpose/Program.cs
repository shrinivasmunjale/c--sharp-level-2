using System;

class Program{

static void Main(){
    int [,] mat = new int[2,3];

    Console.WriteLine("Enter the Element of matrix: ");
    for( int i =0 ; i<2 ; i++){
        for (int j= 0 ; j<3 ; j++){
            Console.WriteLine($"Enter value of {i },{j} element:");
            mat[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine("Matrix with value: ");
    for( int i =0 ; i<2 ; i++){
        for (int j= 0 ; j<3 ; j++){
            
            Console.Write(mat[i,j]+" ");
        }
        Console.WriteLine();
    }

    
    Console.WriteLine("Matrix after tranpose: ");
    for( int i =0 ; i<3 ; i++){
        for (int j= 0 ; j<2 ; j++){
            
            Console.Write(mat[j,i]+" ");
        }
        Console.WriteLine();
    }



}
}