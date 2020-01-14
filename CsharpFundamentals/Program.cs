using System;

namespace CshapFundamentals
{
    class Program
    {
	static void Main(string[] args)
	{
		var builder = new StringBuilder(); // cannot be changed once create
			
		builder.Append('-', 10);
		/*this method can be used to add or append a string value of an object 
		to the end of a string represented by the current StringBuilder object*/
		
		builder.AppendLine();
		/*This method append the string with a newline at the end.*/
		
		builder.Append("Header");
		builder.AppendLine();
		builder.Append('-', 10);
			
		Console.WriteLine(builder);
	}
    }
}
