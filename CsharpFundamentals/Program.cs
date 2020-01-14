using System;

namespace CshapFundamentals
{
    class Program
    {
	internal class Program
	{
		public static void Main(string[] args)
		{	
			string[] element;
			
			while(true)
			{
				Console.WriteLine("Enter a list of comma-separated numbers: ");
				var input = Console.ReadLine();
				
				if(!String.IsNullOrWhiteSpace(input))
				{
					elements = input.Split(',');
					if(elements.Length >= 5)
						break;
				}
				Console.WriteLine("Invalid List");
			}
			
			var number = new List<int>();
			
			foreach(var number in elements)
				number.Add(Convert.TiInt32(number));
			
			var smallest = new List<int>();
			
			while(smallest.Count < 3)
			{
				// Assume the first number is the smallest
				var min = numbers[0];
				foreach(var number in numbers)
				{
					if(number < min)
						min = number;
				}
				smallest.Add(min);
				numbers.Remove(min);
			}
			Console.WriteLine("The 3 smallest numbers are: ");
			foreach(var number in smallest)
				Console.WriteLine(number);
		}
	}
    }
}
