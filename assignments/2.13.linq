<Query Kind="Program" />

void Main()
{
	
	var batchIterator = Enumerable.Range(0, 95).myBatch(10);
	foreach(var batchList in batchIterator)
	{
		foreach (var element in batchList)
		{
			Console.WriteLine(element);
		}
	}
}




public static class ExtensionMethods
{
	public static IEnumerable<IEnumerable<T>> myBatch<T>(this IEnumerable<T> inputEnumerable, int batchSize)
	{
		List<T> tempList = new List<T> ();
	
		foreach(var element in inputEnumerable)
		{	
			tempList.Add(element);
			if (tempList.Count == batchSize)
			{
				Console.WriteLine("BATCH");
				yield return tempList;
				tempList = new List<T> ();
			}
		}
		yield return tempList;
	}
}


class FixedSizeEnumerable : IEnumerable<T>
{
	int _batchSize;
	IEnumerable _enumerable;
	
	public FixedSizeEnumerable(IEnumerable originalEnumerable, int batchSize)
	{
		_batchSize = batchSize;
		_enumerable = originalEnumerable;
	}
	
	public IEnumerator<T> GetEnumerator()
	{
		throw new NotImplementedException();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		throw new NotImplementedException();
	}
}