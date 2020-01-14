using System;

namespace CshapFundamentals
{
    class Program
    {
	static void Main(string[] args)
	{
		var builder = new StringBuilder("Hello World");
			
		builder.Append('-', 10);
		builder.AppendLine();
		builder.Append("Header");
		builder.AppendLine();
		builder.Append('-', 10);
		Console.WriteLine(builder);
			
		/*Replaces a specified character or string with another specified character or string*/	
		builder.Replace('-', '+');
		
		/*Removes the specified range of characters*/
		builder.Remove(0, 10);
			
		/*Inserts the string of a specified object into a specified character position.*/
		builder.Insert(0, new string('-'), 10);
			
		Console.WriteLine(builder);
	}
    }
}
