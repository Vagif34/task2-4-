using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr =  "aıoueəiöü" ;
            string arr2 =  "Salam usaqlar necesiz" ;
            Console.WriteLine(Letter(arr,arr2));
            Letter(arr, arr2);
        }
        static int Letter(string arr, string arr2)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)

                    if (arr[i] == arr2[j])


                        count++;



            }
            return count;

            

            
        }
            
            
            
                 
            
            
        
        
    }
}
