using System;
namespace Harmonic
{
    class HarmonicNumber
    {
        public static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Enter the Number upto You want to print Harmonic number");
            int number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                Console.Write(" 1/{0} +", i);
            }
           
        }
        
    } 
}