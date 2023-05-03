//while (true)
//{
//    var roman = Console.ReadLine().ToUpper();
//    Console.WriteLine(Solution.RomanToInteger(roman));
//}
var guid = Guid.NewGuid().ToString("n");
Console.WriteLine(guid.Length);
public class Solution
{
	private Dictionary<char, int> roman = new()
		{
			{'I',1 },
			{'V',5 },
			{'X',10 },
			{'L',50 },
			{'C',100 },
			{'D',500 },
			{'M',1000 }
		};
	public int RomanToInteger(string number)
	{
		var sum = 0;

		switch (number[0])
		{
			case 'I':
				{
					//rules check
					sum = startWithI(number);
					break;
				}
			case 'V':
				{
					//rules check
					sum = startWithV(number);
					break;
				}
			case 'X':
				{
					//rules check

					if (number[1] == 'L')
					{
						sum += 40;
						number = number.Substring(2, 3);

						if (number[0] == 'I')
							sum = startWithI(number);
						else
							sum = startWithV(number);

						break;
					}
					else if (!number.Contains('V') || !number.Contains('I'))
					{
						sum = number.Length * roman['X'];
						break;
					}
					else if (!number.Contains('I'))
					{
						var numberOfX = number.IndexOf('V');
						sum = (roman['X'] * numberOfX) + roman['V'];
						break;
					}
					else
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

	private int startWithI(string number)
	{
		if (number[1] == 'I')
		{
			return number.Length;
		}
		else if (number[1] == 'V')
		{
			return 4;
		}
		else if (number[1] == 'X')
		{
			return 9;
		}
		else
			return 0;
	}
	private int startWithV(string number)
	{
		return roman['V'] + (number.Length - 1);
	}
}