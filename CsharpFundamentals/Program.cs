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
			var words = sentence.Split(' ');
			var totalCharaters = 0;
			var summaryWords = new List<string>();
				
			foreach(var word in words)
			{
				summaryWords.Add(word);
				totalCharacters += word.Length + 1;
				if(totalCharaters > maxLength)
					break;	
			}
			
			var summary = String.Join(" ", summaryWords) + "...",
			Console.WriteLine(summary);
		}
        }
    }
}
