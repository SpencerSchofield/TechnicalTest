/*
Using names.txt (attached), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
So, COLIN would obtain a score of 938 x 53 = 49714.

What is the total of all the name scores in the file?
*/

//Todo
//Import names.txt + Add names to a list *done
//Order the List by alphabetical order *done
//Set values for each letter in alphabet e.g. a/A = 1, b/B = 2, c/C = 3. *done
//Find total value for name - COLIN = 3 + 15 + 12 + 9 + 14 = 53 then times by position in list *done
//Get total value of all names. *done
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
class TechnicalTest
{
	List<KeyValuePair<string, int>> alphaNumPairs;
	int totalValue;
	public TechnicalTest()
	{
		alphaNumPairs = new List<KeyValuePair<string, int>>();
		SetAlphaNumPairs();
	}

	public static void Main()
	{
		try
		{
			TechnicalTest technicalTest = new TechnicalTest();
			StreamReader file = new StreamReader("names.txt");
			List<string> nameList = new List<string>();

			while (!file.EndOfStream)
			{
				string? name = file.ReadLine();
				string[]? names = name?.Split(',');
				for (int i = 0; i < names?.Length; i++)
				{
					nameList.Add(names[i]);
					//Console.WriteLine("names" + names[i]);
				}
			}
			nameList.Sort();//orders the list alphabetically

			// foreach (string currentName in nameList)
			// {
			// 	Console.WriteLine(currentName);
			// }

			int currentPosition = 1; //Need this to multiple the whole word by position
			for (int i = 0; i < nameList.Count; i++)
			{
				foreach (char c in nameList[i])
				{
					//Console.WriteLine("char :" + c);
					string keyToSearch = c.ToString();
					int retrievedValue = technicalTest.alphaNumPairs.FirstOrDefault(pair => pair.Key == keyToSearch).Value;
					//Console.WriteLine("retrivedValue : " + retrievedValue);
					technicalTest.totalValue += retrievedValue * currentPosition;

				}
				currentPosition++;
			}
			Console.WriteLine(technicalTest.totalValue);
		}
		catch (IOException e)
		{
			Console.WriteLine("The file could not be read: ");
			Console.WriteLine(e.Message);
		}
	}

	/*
	SetAlphaNumPairs() adds keyvaluepairs that represent a number corresponding to it's position in the alphabet
	*/
	void SetAlphaNumPairs()
	{
		//Used for testing, don't need it
		// alphaNumPairs.Add(new KeyValuePair<string, int>(" ", 0));
		// alphaNumPairs.Add(new KeyValuePair<string, int>("/", 0));
		// alphaNumPairs.Add(new KeyValuePair<string, int>(",", 0));
		
		alphaNumPairs.Add(new KeyValuePair<string, int>("A", 1));
		alphaNumPairs.Add(new KeyValuePair<string, int>("B", 2));
		alphaNumPairs.Add(new KeyValuePair<string, int>("C", 3));
		alphaNumPairs.Add(new KeyValuePair<string, int>("D", 4));
		alphaNumPairs.Add(new KeyValuePair<string, int>("E", 5));
		alphaNumPairs.Add(new KeyValuePair<string, int>("F", 6));
		alphaNumPairs.Add(new KeyValuePair<string, int>("G", 7));
		alphaNumPairs.Add(new KeyValuePair<string, int>("H", 8));
		alphaNumPairs.Add(new KeyValuePair<string, int>("I", 9));
		alphaNumPairs.Add(new KeyValuePair<string, int>("J", 10));
		alphaNumPairs.Add(new KeyValuePair<string, int>("K", 11));
		alphaNumPairs.Add(new KeyValuePair<string, int>("L", 12));
		alphaNumPairs.Add(new KeyValuePair<string, int>("M", 13));
		alphaNumPairs.Add(new KeyValuePair<string, int>("N", 14));
		alphaNumPairs.Add(new KeyValuePair<string, int>("O", 15));
		alphaNumPairs.Add(new KeyValuePair<string, int>("P", 16));
		alphaNumPairs.Add(new KeyValuePair<string, int>("Q", 17));
		alphaNumPairs.Add(new KeyValuePair<string, int>("R", 18));
		alphaNumPairs.Add(new KeyValuePair<string, int>("S", 19));
		alphaNumPairs.Add(new KeyValuePair<string, int>("T", 20));
		alphaNumPairs.Add(new KeyValuePair<string, int>("U", 21));
		alphaNumPairs.Add(new KeyValuePair<string, int>("V", 22));
		alphaNumPairs.Add(new KeyValuePair<string, int>("W", 23));
		alphaNumPairs.Add(new KeyValuePair<string, int>("X", 24));
		alphaNumPairs.Add(new KeyValuePair<string, int>("Y", 25));
		alphaNumPairs.Add(new KeyValuePair<string, int>("Z", 26));
	}

}