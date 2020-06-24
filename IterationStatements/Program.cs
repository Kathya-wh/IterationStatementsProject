using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numbers = new List<int>();
           
            var myNumber = 0;
            

            do
            {
               
                myNumber++;

                numbers.Add(myNumber);

            } while (myNumber < 100);

            
           
            while(myNumber < 200)
            {
              myNumber++;
              numbers.Add(myNumber);
                 
            }

            Console.WriteLine("Increase:");

            foreach(int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

          
            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers [i]);
            }   
            
        }
    }
}
