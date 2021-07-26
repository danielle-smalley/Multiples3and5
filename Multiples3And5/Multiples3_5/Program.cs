using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3_5
{
    class Program
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

            int sum = 0;
            for (int i = 1; i < 1000; i++) //using a for loop starting with 1 to 1000 and incrementing to count
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);


        }//end main
    }//end class
}//end namespace
