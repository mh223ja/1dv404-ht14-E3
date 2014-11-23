using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestNumber= 0;
            int secondLargest = 0;
            int numbers;

            for (int i= 0; i<10; i++)
            {
                Console.WriteLine("Input number: ");
                numbers = int.Parse(Console.ReadLine());
            

            if (numbers > largestNumber)
            {
                secondLargest = largestNumber;
                largestNumber = numbers;
            }
            
            if (numbers < largestNumber && numbers > secondLargest)
            {
                secondLargest = numbers;
            }
            }
            Console.WriteLine("The second largest number is:{0}", secondLargest);
        }
    }
}
