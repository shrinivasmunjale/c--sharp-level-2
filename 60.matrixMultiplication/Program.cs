 using System ;

 class Program {
    static void Main(){

        int [,] a = {
            {1,3},
            {3,5}
        };
        int [,] b = {
            {1,3},
            {3,5}
        };

        int[,] result = new int [2,2];
        for(int i =0 ; i<2 ; i++){
            for(int j= 0 ; j< 2 ; j++){
                for (int k = 0; k< 2 ; k++){

                result[i,j] += a[i,k] * b[k,j];
                }
            }
        }

        Console.WriteLine("Result Matrix:");

        for(int i=0 ; i<2 ; i ++){
            for (int j= 0 ; j<2 ; j ++ ){
                Console.Write(result[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
 }
