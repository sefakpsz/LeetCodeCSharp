//while (true)
//{
//    var roman = Console.ReadLine().ToUpper();
//    Console.WriteLine(Solution.RomanToInteger(roman));
//}
var guid= Guid.NewGuid().ToString("n");
Console.WriteLine(guid.Length);
public static class Solution
{
    public static int RomanToInt(string s)
    {
        if (!s.Contains('M'))
        {
            if (!s.Contains('D'))
            {
                if (!s.Contains('C'))
                {
                    if (!s.Contains('X'))
                    {
                        if (!s.Contains('V'))
                        {
                            if (s.Length > 3)
                                throw new Exception("Error: Invalid Value Entered!");

                            return s.Length;
                        }
                        if (s.IndexOf('V') != s.LastIndexOf('V'))
                            throw new Exception("Error: Invalid Value Entered!");

                        if (s.Length > 4)
                        {
                            throw new Exception("Error: Invalid Value Entered!");
                        }
                        else if (s[0].ToString().ToUpper() != "V")
                        {
                            return 4;
                        }
                        else if (s.Contains('I'))
                        {
                            return s.LastIndexOf("I") + 5;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                    if (s[2] == 'X')
                        return 19;
                    if (s[0] == 'I')
                    {
                        if (s.Length > 2)
                            throw new Exception("Error: Invalid Value Entered!");

                        return 9;
                    }
                    if (s.Contains('V'))
                    {
                        if (s.IndexOf('V') != s.LastIndexOf('V'))
                            throw new Exception("Error: Invalid Value Entered!");

                        if (s[1] == 'I')
                            return 14;

                        if (s.Length > 5)
                            throw new Exception("Error: Invalid Value Entered!");

                        return 15 + (s.Length - 2);
                    }
                    else
                    {
                        if (s.Length > 4)
                            throw new Exception("Error: Invalid Value Entered!");

                        return 10 + (s.Length - 1);
                    }
                }
                return 0;
            }
            return 0;
        }
        return 0;
    }

    public static int RomanToInteger(string s)
    {
        Dictionary<string, int> romanChar = new()
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "X", 10 },
            { "IX", 9 },
            { "L", 50 },
            { "XL", 40 },
            { "C", 100 },
            { "XC", 90 },
            { "D", 500 },
            { "CD", 400 },
            { "M", 1000 },
            { "CM", 900 }
        };

        Dictionary<int, string> romanInt = new()
        {
            { 1   , "I"      },
            { 4   , "IV"    },
            {  5  , "V"     },
            { 10  , "X"     },
            { 9   , "IX"    },
            { 50  , "L"     },
            { 40  , "XL"    },
            { 100 , "C"     },
            { 90  , "XC"    },
            { 500 , "D"     },
            { 400 , "CD"    },
            { 1000, "M"      },
            { 900 , "CM"    }
        };
        var sum = 0;

        for (int i = s.Length - 1; i > 0; i--)
        {
            if (s[i].ToString() == romanInt[1])
            {
                sum += romanChar["I"];
            }
            else if (s[i].ToString() == romanInt[5])
            {
                if (s[i - 1].ToString() == romanInt[1])
                {
                    sum += romanChar["IV"];
                    i--;
                }
                else
                {
                    sum += romanChar["V"];
                }
            }
            else if (s[i].ToString() == romanInt[10])
            {
                if (s[i - 1].ToString() == romanInt[1])
                {
                    sum += romanChar["IV"];
                    i--;
                }
                else
                {
                    sum += romanChar["V"];
                }
            }
        }

        return sum;
    }
}