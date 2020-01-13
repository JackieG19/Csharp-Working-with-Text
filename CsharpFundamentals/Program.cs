using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani";   
            //var index = fullName.IndexOf(' ');
         
           	var names = fullName.Split(' ');
            /*This method splits a string into an array of strings separated by the split delimeters. 
            The split delimiters can be a character or an array of characters or an array of strings.*/
			
            Console.WriteLine("FirstName" + name[0]);
			Console.WriteLine("LastName" + name[1]);
        }
    }
}
