<Query Kind="Program" />

class MyEnumerator : IEnumerator
{
	List<string> _myList = new List<string> {"Hi", "Hello"};
	int currentPosition = -1;

	public object Current
	{
		get
		{
			try
			{
				return _myList[currentPosition];
			}
			catch (IndexOutOfRangeException)
			{
				throw new InvalidOperationException();
			}
		}
	}

	public bool MoveNext()
	{
		currentPosition++;
		// as long as it is not the end of the list, move forward
		return (currentPosition < _myList.Count);
	}
	
	public void Reset()
	{
		throw new NotImplementedException();
	}
	
	
}

class MyEnumerable : IEnumerable
{
	public IEnumerator GetEnumerator()
	{
		return new MyEnumerator();
	}
}

void Main()
{
	var myClass = new MyEnumerable();
	foreach (var element in myClass)
	{
		Console.WriteLine(element);
	}
	
}

// Define other methods, classes and namespaces here
