while (true)
{
    var roman = Console.ReadLine().ToUpper();
    Console.WriteLine(Solution.RomanToInteger(roman));
}
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
        Dictionary<char, int> romanChar = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        Dictionary<int, char> romanInt = new()
        {
            { 1, 'I' },
            { 5, 'V' },
            { 10, 'X' },
            { 50, 'L' },
            { 100, 'C' },
            { 500, 'D' },
            { 1000, 'M' }
        };

        var m = s.IndexOf("M");
        var c = s.IndexOf("C");
        var d = s.IndexOf("D");
        var l = s.IndexOf("L");
        var x = s.IndexOf("X");
        var v = s.IndexOf("V");
        var i = s.IndexOf("I");

        List<int> ints = new()
        {
            m,c,d,l,x,v,i
        };
        foreach (var item in ints)
        {
            if (m > item)
            {
                if (s[item] != 'C')
                {
                    throw new Exception("Invalid Value!");
                }
            }

        }


        var sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sum += romanChar[s[i]];
        }

        return sum;
    }
}