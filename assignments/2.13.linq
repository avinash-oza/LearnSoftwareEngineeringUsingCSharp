<Query Kind="Program" />

void Main()
{
	var x = Enumerable.Range(0, 100);
	foreach(var y in x)
	{
		Console.WriteLine(y);
	}
}



public static class MyExtensionMethods
{
	public static IEnumerable<IEnumerable<T>> Batch(this IEnumerable<T> resultIterator, int batchSize=100)
	{
		
	}
}

// Define other methods, classes and namespaces here


//class InnerIterator: IEnumerable<int>
//{
//	
//}
//
//class BatchIterator: IEnumerable<int>
//{
//	IEnumerable myItems = Enumerable.Range(0, 100);
//	
//}