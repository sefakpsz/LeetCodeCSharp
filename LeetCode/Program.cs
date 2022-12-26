while (true)
{
    var roman = Console.ReadLine().ToUpper();
    Console.WriteLine(Solution.RomanToInt(roman));
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
                            if(s.Length>3)
                            {
                                throw new Exception("Error: Invalid Value Entered!");
                            }
                            return s.Length;
                        }
                        if (s.Length > 4)
                        {
                            throw new Exception("Error: Invalid Value Entered!");
                        }
                        else if (s[0].ToString().ToUpper() != "V")
                        {
                            return 4;
                        }
                        else if(s.Contains('I'))
                        {
                            return s.LastIndexOf("I") + 5;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                    if (s[0] == 'I')
                    {
                        if (s.Length > 2)
                        {
                            throw new Exception("Error: Invalid Value Entered!");
                        }
                        return 9;
                    }
                    if (s.Contains('V'))
                    {
                        if (s.Length > 5)
                        {
                            throw new Exception("Error: Invalid Value Entered!");
                        }
                        return 15 + (s.Length - 2);
                    }
                    else
                    {
                        if (s.Length > 4)
                        {
                            throw new Exception("Error: Invalid Value Entered!");
                        }
                        return 10 + (s.Length - 1);
                    }
                }
                return 0;
            }
            return 0;
        }
        return 0;
    }
}