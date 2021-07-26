using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiples3And5;

namespace Multiples3And5
{
    public class Class1
    {
        static void Main(string[] args)
        {
            /*
             * If we list all the natural numbers below 10
                that are multiples of 3 or 5, we get 3, 5,
                6 and 9. The sum of these multiples is 23.

                Find the sum of all the multiples of 3 or 5 below 1000 and print it out to the console.

                Remember to commit changes to the repository. Submit your repo url to this assignment. 
             */

            //max number
            //int maxNumber = 999; //needs to be below 1000
            //int mult3 = maxNumber / 3; //multiples of 3
            //int mult5 = maxNumber / 5; //multiples of 5

            int sum = 0; //start at 0 then we'll be adding onto it as the loop filters out our multiples
            for (int i = 0; i < 1000; i++) //using a for loop for a starting place, ending place (999 since 1000 shouldn't be included, but we set to 1000 to go up to 999), and for incrementing to count/sum
            {
                if (i % 3 == 0 || i % 5 == 0)//using a modulus to check for multiples of 3 and 5
                {
                    sum += i; //if number is a multiple of 3 or 5, we're adding it to the sume
                }
                //Console.WriteLine(i);
            }
            Console.WriteLine(sum); //display results 
        }


    }
}
