using System;

namespace CshapFundamentals
{
    class Program
    {
	static void Main(string[] args)
	{
		var sentence = "This is going to be a really really really really really long text";
		var summary = SummerizeText(sentence);
		Console.WriteLine(summary, 25);
	}
    }
}
