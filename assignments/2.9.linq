<Query Kind="Program" />

void Main()
{
	var myList = new List<string> {"Hello", "hi", "Hello", "abc"};
	var results = myList.Where(x => x.Equals("Hello")). Select(l => l + "AAA");
	// use own implementation of Select
	var results2 = myList.Where(x => x.Equals("Hello")).mySelect(l => l + "BBB");
	
	foreach (var element in results)
	{
		Console.WriteLine(element);
	}
	
	Console.WriteLine("XXX");

	foreach (var element in results)
	{
		Console.WriteLine(element);
	}

}

public static class LinqExtensionMethods
{
	public static IEnumerable<TOut> mySelect<T, TOut>(this IEnumerable<T> theSequence, Func<T, TOut> myFunc)
	{
		foreach (var element in theSequence)
		{
			yield return myFunc(element);
		}
	}

}


