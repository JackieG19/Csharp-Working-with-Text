using System;

namespace CSharpFundamentals
{
	public class StringUtility
	{
		public static string SummerizeText(string text, int maxLength = 20;)
		{	
			if(text.Length < maxLength)
				return text;
				
			var words = text.Split(' ');
			var totalCharaters = 0;
			var summaryWords = new List<string>();
				
			foreach(var word in words)
			{
				summaryWords.Add(word);
				totalCharacters += word.Length + 1;
				if(totalCharaters > maxLength)
					break;	
			}
			
			return String.Join(" ", summaryWords) + "...",
			// return summary;
			}
		}
	}
}
