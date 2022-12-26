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
        Dictionary<char, int> roman = new();
        roman.Add('I', 1);
        roman.Add('V', 5);
        roman.Add('X', 10);
        roman.Add('L', 50);
        roman.Add('C', 100);
        roman.Add('D', 500);
        roman.Add('M', 1000);

        for (int i = 0; i < s.Length; i++)
        {

        }

        return 0;
    }
}