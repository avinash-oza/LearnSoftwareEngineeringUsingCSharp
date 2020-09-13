<Query Kind="Program" />

void Main()
{
	GetCovers().Dump();
}

public IEnumerable<CoverInfo> GetCovers()
{
	//Implement this method. 
	
	var longPositions = GetLongs().GetEnumerator();
	// probably need some more checks here
	longPositions.MoveNext();
	var currentLong = longPositions.Current;
	var longAmount = currentLong.Amount;
	
	foreach (var shortPosition in GetShorts())
	{
		int sum = shortPosition.Amount;	
		var coveringPositions = new List<PositionInfo>();
		
		while(sum < 0)
		{
			if (longAmount == 0)
			{
				// move to next long. Needs more checking here
				longPositions.MoveNext();
				currentLong = longPositions.Current;
				longAmount = currentLong.Amount;
			}
			int amountOffset = Math.Min(Math.Abs(sum), longAmount);
			sum += amountOffset;
			longAmount -= amountOffset;
			coveringPositions.Add(new PositionInfo(){Account = currentLong.Account, Amount = amountOffset});
		}
			
		var coverInfo = new CoverInfo() { ShortPosition = shortPosition, Covers =  coveringPositions};
		yield return coverInfo;
	}
}

public class PositionInfo
{
	public string Account { get; set; }

	public int Amount { get; set; }
}

public IEnumerable<PositionInfo> GetLongs()
{
	yield return new PositionInfo { Account = "A", Amount = 100 };
	yield return new PositionInfo { Account = "B", Amount = 300 };
	yield return new PositionInfo { Account = "C", Amount = 200 };
}

public IEnumerable<PositionInfo> GetShorts()
{
	yield return new PositionInfo { Account = "X", Amount = -120 };
	yield return new PositionInfo { Account = "Y", Amount = -250 };
	yield return new PositionInfo { Account = "Z", Amount = -170 };
}

public class CoverInfo
{
	public PositionInfo ShortPosition { get; set; }
	public List<PositionInfo> Covers { get; set; }
}
