using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
		var fullName = "Jackie Gut";  
		
		// It returns true if the string contains only whitespace characters or is null.
         	if(String.IsNullOrEmpty(Null))
    			Console.WriteLine("Invalid");
    		
    		if(String.IsNullOrEmpty("")) // empty string
    			Console.WriteLine("Invaild");
    		
		// this doesn't work
    		if(String.IsNullOrEmpty(" ")) // a space
    			Console.WriteLine("Invaild");
    		
    		if(String.IsNullOrEmpty(" ".Trim())) // trim the empty string
    			Console.WriteLine("Invaild");
        }
    }
}
