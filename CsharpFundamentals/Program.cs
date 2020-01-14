using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
		float price = 29.95f;
    		//price.ToString("C")
    		
		/*Converts the value of this instance to a String.*/
		Console.WriteLine(price.ToString("C")); // "C" - a currency value.
		// 29.95
    		
		/*the method format the numeric value with currency sign and without any decimal digit*/
		Console.WriteLine(price.ToString("C0")); // $2,995
        }
    }
}
