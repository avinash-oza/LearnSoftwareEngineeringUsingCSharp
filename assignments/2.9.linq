<Query Kind="Program" />

void Main()
{
	var myList = new List<string> {"Hello", "hi", "Hello", "abc"};
	var results = myList.Where(x => x.Equals("Hello"));
	var results2 = myList.First(x => x.Equals("Hello"));
	// var results3 = myList.Single(x => x.Equals("Hello"));
	
	Console.WriteLine(results2);
	Console.WriteLine("XXX");
	//Console.WriteLine(results3);
	Console.WriteLine("YYY");
	
	
	foreach (var element in results)
	{
		Console.WriteLine(element);
	}
	
}

// Define other methods, classes and namespaces here
