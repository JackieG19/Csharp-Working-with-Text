using System;

namespace CshapFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
		var sentence = "This is going to be a really really really really really long text";
		const int maxLength = 20;
			
			if(sentence.Length < maxLength)
				Console.WriteLine(sentnece);
			else
			{
				sentence.Substring(0, maxLength);
			}
        }
    }
}
