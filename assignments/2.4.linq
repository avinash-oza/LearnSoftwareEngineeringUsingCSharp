<Query Kind="Program" />

void Main()
{
	IEnumerator<string> myIter = GetItems().GetEnumerator();
	while(myIter.MoveNext())
	{
		Console.WriteLine(myIter.Current);
	}
	
}

public IEnumerable<string> GetItems()
{
	yield return "Hi";
	yield return "Hello";
	yield return "Hello2";
}

// Define other methods, classes and namespaces here
