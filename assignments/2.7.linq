<Query Kind="Program" />


public delegate int Operator(int x, int y);

int myFunc(Operator x)
{
	return x(2, 3);
}

int myFunc2(Func<int, int, int> x)
{
	return x(2, 3);
}

void Main()
{
	Console.WriteLine(myFunc((x, y) => x + y));
	Console.WriteLine(myFunc2((x, z) => x* 2));
}

// Define other methods, classes and namespaces here
