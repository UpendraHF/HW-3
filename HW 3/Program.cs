using System;

public class PigLatinStrings
{
	public static void Main(string[] args)
	{
		string first;
		string last;
		string pigLatinFirst;
		string pigLatinLast;
		string pigLatinName;

		first = "mark";
		last = "aloka";

		pigLatinFirst = first.Substring(1) + first[0] + "ay";
		pigLatinLast = last.Substring(1) + last[0] + "ay";

		pigLatinFirst = pigLatinFirst.Substring(0, 1).ToUpper() + pigLatinFirst.Substring(1);

		pigLatinLast = pigLatinLast.Substring(0, 1).ToUpper() + pigLatinLast.Substring(1);

		pigLatinName = pigLatinFirst + " " + pigLatinLast;

		Console.WriteLine("First Name:    " + first);
		Console.WriteLine("Last Name:     " + last);
		Console.WriteLine("PigLatin Name: " + pigLatinName);
	}
}
