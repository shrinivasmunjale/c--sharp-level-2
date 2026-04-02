using System;

class Program{
    static void Main(){
        int [] arr = {2,5,4,76,42,24};

        int key = 4;

        for(int i=0 ; i<arr.Length ; i++){
            if(key == arr[i]){
                Console.WriteLine($"element found at {i} index");
            }
            else{
                Console.WriteLine("Element not found..");
            }
        }
    }
}

