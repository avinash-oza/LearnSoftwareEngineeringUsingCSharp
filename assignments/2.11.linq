<Query Kind="Program" />

void Main()
{
	var myList = new List<string> {"Hello", "hi", "Hello", "abc"};
	var myResultLinq = myList.FirstOrDefault(x => x == "hi");
	var myResult = myList.myFirstOrDefault(x => x == "hi");

	var myResultLinqDefault = myList.FirstOrDefault(x => x == "not here");
	var myResultDefault = myList.myFirstOrDefault(x => x == "not here", "NOT HERE");


	Console.WriteLine(myResultLinq);
	Console.WriteLine(myResult);

	Console.WriteLine("DEFAULT" + myResultLinqDefault);
	Console.WriteLine("DEFAULT" + myResultDefault);
}

public static class LinqExtensionMethods
{
	public static T myFirstOrDefault<T>(this IEnumerable<T> theSequence, Func<T, bool> filterPredicate, T defaultValue=default(T))
	{
		foreach (var element in theSequence)
		{
			if (filterPredicate(element))
			{
				return element;
			}
		}
		return defaultValue;
	}
}

// Define other methods, classes and namespaces here
