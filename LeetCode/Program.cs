//while (true)
//{
//    var roman = Console.ReadLine().ToUpper();
//    Console.WriteLine(Solution.RomanToInteger(roman));
//}
var guid = Guid.NewGuid().ToString("n");
Console.WriteLine(guid.Length);
public static class Solution
{
	public static int RomanToInteger(string number)
	{
		var sum = 0;


		Dictionary<char, int> roman = new()
		{
			{'I',1 },
			{'V',5 },
			{'X',10 },
			{'L',50 },
			{'C',100 },
			{'D',500 },
			{'M',1000 }
		};

		switch (number[0])
		{
			case 'I':
				{
					//rules check
					if (number[1] == 'I')
					{
						sum = number.Length * roman['I'];
						break;
					}
					else if (number[1] == 'V')
					{
						sum = 4;
						break;
					}
					else if (number[1] == 'X')
					{
						sum = 9;
						break;
					}
					else
						break;
				}
			case 'V':
				{
					//rules check
					sum = roman['V'] + (number.Length - 1);
					break;
				}
			case 'X':
				{
					// DIDN'T INCLUDE CASE OF CONTAINS L


					//rules check
					if (!number.Contains('V') || !number.Contains('I') || !number.Contains('L'))
					{
						sum = number.Length * roman['X'];
						break;
					}
					else if (!number.Contains('I') || !number.Contains('L'))
					{
						var numberOfX = number.IndexOf('V');
						sum = (roman['X'] * numberOfX) + roman['V'];
						break;
					}
					else if (!number.Contains('L'))
					{
						var numberOfX = number.IndexOf('V');

						var indexOfI = number.IndexOf('I');
						var indexOfV = number.IndexOf('V');
						if (indexOfV < indexOfI)
						{
							sum = (roman['X'] * numberOfX) + 4;
							break;
						}
						else
						{
							var numberOfI = number.Length - indexOfI;
							sum = (roman['X'] * numberOfX) + roman['V'] + (numberOfI * roman['I']);
							break;
						}
					}
					else
						break;
				}
			case 'L':
				{
					break;
				}
			case 'C':
				{
					break;

				}
			case 'D':
				{
					break;

				}
			case 'M':
				{
					break;

				}
			default:
				break;
		}

		return sum;
	}
}