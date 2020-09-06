<Query Kind="Program" />

void Main()
{
	var myList = new List<string> { "Hello", "hi", "Hello", "abc" };
	var myResult = myList.mySingleOrDefault(x => x == "Hello", "MISSING");
	var myResultLinq = myList.SingleOrDefault(x => x == "Hello");


	Console.WriteLine(myResultLinq);
	Console.WriteLine(myResult);
}

public static class LinqExtensionMethods
{
	public static T mySingleOrDefault<T>(this IEnumerable<T> theSequence, Func<T, bool> filterPredicate, string customMessage="Multiple values meeting condition")
	{
		int _counter = 0;
		T _element = default(T);
		foreach (var element in theSequence)
		{
			if (filterPredicate(element))
			{
				_counter++;
				_element = element;
			}
			if (_counter > 1)
			{
				throw new Exception(customMessage);
			}
		}
		
		if(_counter == 1)
		{
			return _element;
		}
		return default(T);
	}
}

// Define other methods, classes and namespaces here
