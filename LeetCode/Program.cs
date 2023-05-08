//while (true)
//{
//    var roman = Console.ReadLine().ToUpper();
//    Console.WriteLine(Solution.RomanToInteger(roman));
//}
var romans = Console.ReadLine();
var roman = romans.Split(" ");
Console.WriteLine(new Solution().RomanToInteger(roman[0].Trim().ToUpper()));
Console.ReadKey();

/*
 
MCMXCV (1995) algorithm is incorrect for this number
MMMCCCLXXXI (3381)
CXCIII (193)
MMMCXXXVII (3137) 
MMMCCLXXXI (3281)
MMMCDLXXVI (3476)
MMMCCXVI (3216)
MMMDCCXXXVI (3736)
MLXXIX (1079)
LXIX (69)
MCLXX (1170)
MCDLXXIX (1479)
DCCLXXV (775)
DCXLIV (644)
MMMCCCXVI (3316)
MMDCCCLXXXVIII (2888)
DXL (540)
MCDLXXXIX (1489)
MCCCXXIV (1324)
MMDCCXLVIII (2748)
MMMDCCCLXXIX (3879)
MMMLIV (3054)
MMDXLIV (2544)
MMDLXXV (2575)
CLXXVIII (178)
MMMDXCIII (3593)
CCCLIII (353)
LIX (59)
MMCCCXXIV (2324)
MMMDLIX (3559)
MMMCMXXV (3925)
XLIX (49)
MXLVII (1047)
MMCCVII (2207)
MMMDCVIII (3608)
MMMDCXXXII (3632)
MMMCLXXXVIII (3188)
MMCCCXCII (2392)
MDCXLVIII (1648)
MCCLVIII (1258)
MDCCCLXIX (1869)
MMMDXXVI (3526)
MMMDXCVI (3596)
MCCVIII (1208)

 */


public class Solution
{
	private Dictionary<char, short> roman = new()
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
		short sum = 0;

		switch (number[0])
		{
			case 'I':
				{
					sum = startWithI(number, sum);
					break;
				}
			case 'V':
				{
					//rules check
					sum = startWithV(number, sum);
					break;
				}
			case 'X':
				{
					//rules check
					sum = startWithX(number, sum);
					break;
				}
			case 'L':
				{
					//rules check
					sum = startWithL(number, sum);
					break;
				}
			case 'C':
				{
					//rules check
					sum = startWithC(number, sum);
					break;
				}
			case 'D':
				{
					//rules check
					sum = startWithD(number, sum);
					break;
				}
			case 'M':
				{
					//rules check
					sum = startWithM(number, sum);
					break;
				}
			default:
				break;
		}

		return sum;
	}

	private short startWithI(string number, short sum)
	{
		var lengthOfNumber = number.Length;
		if (lengthOfNumber > 1)
		{
			if (number[1] == 'I')
			{
				if (lengthOfNumber > 3)
					throw new Exception("Roman number of I can't be written 4 times consecutively");

				sum += (short)number.Length;
				return sum;
			}
			else if (number[1] == 'V')
			{
				var indexOfV = number.IndexOf('V');
				if (lengthOfNumber != indexOfV + 1)
					throw new Exception("Roman number of V can't be written 2 times consecutively");

				sum += 4;
				return sum;
			}
			else if (number[1] == 'X')
			{
				var indexOfX = number.IndexOf('X');
				if (lengthOfNumber != indexOfX + 1)
					throw new Exception("Roman number of X can't be written 2 times consecutively in this context");
				sum += 9;
				return sum;
			}
		}
		else
			sum++;

		return sum;
	}
	private short startWithV(string number, short sum)
	{
		sum += 5;
		if (number.Length > 1)
		{
			number = number[1..];
			if (number[0] == 'I')
				sum = startWithI(number, sum);
			else
				throw new Exception("Roman number of V can't be written 2 times consecutively");
			return sum;
		}
		else
			return sum;
	}
	private short startWithX(string number, short sum)
	{
		if (number[1] == 'L')
		{
			if (number[2] == 'L')
				throw new Exception("Roman number of L can't be written 2 times consecutively in this context.");

			sum += 40;
			number = number[2..];
		}
		else if (number[1] == 'C')
		{
			if (number[2] == 'C')
				throw new Exception("Roman number of L can't be written 2 times consecutively in this context.");

			sum += 90;
			number = number[2..];
		}
		else
		{
			short numberOfX = (short)number.LastIndexOf('X');
			if (numberOfX > 2)
			{
				sum += (short)((numberOfX - 1) * roman['X']);
				number = number[(numberOfX - 1)..];
			}
			else if (numberOfX == 0 || numberOfX == 1)
			{
				sum += roman['X'];
				number = number[1..];
			}
			else if (numberOfX == 2)
			{
				sum += (short)((numberOfX + 1) * roman['X']);
				number = number[(numberOfX + 1)..];
			}
		}

		if (number[0] == 'V')
			sum = startWithV(number, sum);
		else if (number[0] == 'I')
			sum = startWithI(number, sum);

		return sum;
	}
	private short startWithL(string number, short sum)
	{
		var indexOfLastL = (short)number.LastIndexOf('L');
		if (indexOfLastL == 0)
		{
			sum += roman['L'];
			number = number[1..];
		}
		else
		{
			sum += (short)((indexOfLastL + 1) * roman['L']);
			number = number[(indexOfLastL + 1)..];
		}

		if (number[0] == 'X')
			sum = startWithX(number, sum);
		else if (number[0] == 'V')
			sum = startWithV(number, sum);
		else if (number[0] == 'I')
			sum = startWithI(number, sum);

		return sum;
	}
	private short startWithC(string number, short sum)
	{
		if (number[1] == 'M')
		{
			sum += 900;
			number = number[2..];
		}
		else if (number[1] == 'D')
		{
			sum += 400;
			number = number[2..];
		}
		else
		{
			short numberOfC = (short)number.LastIndexOf('C');
			if (numberOfC > 2)
			{
				sum += (short)((numberOfC - 1) * roman['C']);
				number = number[(numberOfC - 1)..];
			}
			else if (numberOfC == 0 || numberOfC == 1)
			{
				sum += (short)roman['C'];
				number = number[1..];
			}
			else if (numberOfC == 2)
			{
				sum += (short)((numberOfC + 1) * roman['C']);
				number = number[(numberOfC + 1)..];
			}
		}

		if (number[0] == 'L')
			sum = startWithL(number, sum);
		else if (number[0] == 'X')
			sum = startWithX(number, sum);
		else if (number[0] == 'V')
			sum = startWithV(number, sum);
		else if (number[0] == 'I')
			sum = startWithI(number, sum);

		return sum;
	}
	private short startWithD(string number, short sum)
	{
		var indexOfLastD = number.LastIndexOf('D');
		if (indexOfLastD == 0 || indexOfLastD == 1)
		{
			sum += (short)roman['D'];
			number = number[1..];
		}
		else
		{
			sum += (short)((indexOfLastD + 1) * roman['D']);
			number = number[(indexOfLastD + 1)..];
		}


		if (number[0] == 'C')
			sum = startWithC(number, sum);
		else if (number[0] == 'L')
			sum = startWithL(number, sum);
		else if (number[0] == 'X')
			sum = startWithX(number, sum);
		else if (number[0] == 'V')
			sum = startWithV(number, sum);
		else if (number[0] == 'I')
			sum = startWithI(number, sum);
		return sum;
	}
	private short startWithM(string number, short sum)
	{
		var indexOfLastM = number.LastIndexOf('M');
		if (indexOfLastM > 2)
		{
			sum += (short)((indexOfLastM - 1) * roman['M']);
			number = number[(indexOfLastM - 1)..];
		}
		else if (indexOfLastM == 0 || indexOfLastM == 1)
		{
			sum += (short)roman['M'];
			number = number[1..];
		}
		else
		{
			sum += (short)((indexOfLastM + 1) * roman['M']);
			number = number[(indexOfLastM + 1)..];
		}

		if (number[0] == 'D')
			sum = startWithD(number, sum);
		else if (number[0] == 'C')
			sum = startWithC(number, sum);
		else if (number[0] == 'L')
			sum = startWithL(number, sum);
		else if (number[0] == 'X')
			sum = startWithX(number, sum);
		else if (number[0] == 'V')
			sum = startWithV(number, sum);
		else if (number[0] == 'I')
			sum = startWithI(number, sum);
		return sum;
	}
}