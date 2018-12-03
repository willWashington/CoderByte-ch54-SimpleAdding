using System;
using System.Collections.Generic;
using System.Linq;

namespace CoderByte_SimpleAdding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, have the function SimpleAdding(num) add up all the numbers from 1 to num. 
            //For example: if the input is 4 then your program should return 10 because 1 + 2 + 3 + 4 = 10. 
            //For the test cases, the parameter num will be any number from 1 to 1000. 

            Console.WriteLine(FirstAddition(14));
            Console.ReadLine();
        }

        static int FirstAddition(int num)
        {
            int result = 0;
            List<int> nums = new List<int>();
            int counter = 0;
            while (counter < num)
            {
                nums.Add(num);
                num--;
            }
            result = nums.Aggregate((a, x) => a + x);

            return result;
        }
    }
}

