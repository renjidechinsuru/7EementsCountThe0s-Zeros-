using System;

namespace _7EementsCountThe0s_Zeros_
{
    class Program
    {
        static void Main(string[] args)
        //Declare an array of 7 elements. Take input from user to initialize the array and count the 0s(Zeros) in the array.
        {
            int count = 0;
                int numbers = 7;

            for (int i = 0; i < numbers; i++)
            {

                Console.WriteLine("Please Enter a number");
                string input = Console.ReadLine();
                if (Convert.ToInt32(input) == 0)
                

                
            
                count = count + 1;
            }
            {
                Console.WriteLine("there is " + count + " of 0s");
            }


        }
    }
}
            
