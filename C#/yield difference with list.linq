<Query Kind="Program" />

void Main()
{
	var yielded = GetDataYield();
	var straighted = GetDataStraight();
	
	(yielded.First() == yielded.First()).Dump("Yielded first equal to yielded second?");
	(straighted.First() == straighted.First()).Dump("Straight first equal to straight second?");
}

public IEnumerable<DTO> GetDataYield()
{
 	".GetDataYield()".Dump();
  yield return new DTO();
}

public IEnumerable<DTO> GetDataStraight()
{
	".GetDataStraight()".Dump();
  return new List<DTO>{new DTO()};
}

public  class DTO {
	public DTO()
	{		
	}	
}

// Define other methods and classes here