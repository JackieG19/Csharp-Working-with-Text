using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani";
            
            var index = fullName.IndexOf(' ');
            
           	var firstName = fullName.Substring(0, index);
    		var lastName = fullName.Substring(index + 1);
            /*Substring() is used to retrieve a substring from the current instance of the string. 
            This method can be overloaded by passing the different number of parameters to it.*/
    		Console.WriteLine("FirstName: " + firstName);
    		Console.WriteLine("LastName: " + LastName);
        }
    }
}
