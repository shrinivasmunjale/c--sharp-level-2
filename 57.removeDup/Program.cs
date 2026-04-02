using System;

class Program
{
    static void Main()
    {
        int [] arr = {12,43,23,11,12};
       int [] temp  = new int [arr.Length];
       int k = 0; // to track the uniqe element;
       bool isDuplicate;



        for (int i= 0 ; i<arr.Length ; i++)
        {
          isDuplicate = false;

          for(int j =0 ; j<k ; j++)
            {
                if (arr[i] == temp[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                temp[k]= arr[i];
                k++;
            }
        }
         Console.WriteLine("Array after removing duplicates:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(temp[i] + " ");
        }


           
            
        }

}
