using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
		var str = "25";
    		//Convert.ToInt32(str);
    		
		var age = Convert.ToByte(str);
    		//Converts the specified string representation of a number to an integer.
		Console.WriteLine(age);
        }
    }
}
