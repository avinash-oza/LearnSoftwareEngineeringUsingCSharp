<Query Kind="Program" />

public IEnumerable<String> GetItems()
{
	yield return "Hi";
	yield return "Hello";
}


void Main()
{
	foreach(var s in GetItems())
	{
		Console.WriteLine(s);
	}
	
}

// Define other methods, classes and namespaces here
