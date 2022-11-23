var s = Console.ReadLine();
Console.WriteLine(new Solution().RomanToInt(s));
public class Solution
{
    public int RomanToInt(string s)
    {
        return 0;
    }
}
//third        
        var tens = 1;
        while (retry != 0)
        {
            tens *= 10;
            retry--;
        }

        var numsString = x.ToString();

        for (int i = 0; i < numsString.Length; i++)
        {
            nums[i] = Convert.ToInt32(numsString.Substring(i, 1));
        }

        //Write loop that can add x with digitly into "nums" array

        if (digit % 2 == 0)
        {
            var size = digit / 2;
            for (int i = 0; i < size; i++)
            {
                if (nums[i] != nums[nums.Length - 1])
                    return false;
            }
        }
        else
        {
            var size = (digit - 1) / 2;
            for (int i = 0; i < size; i++)
            {
                if (nums[i] != nums[size - 1])
                    return false;
            }
        }
        return true;
    }
}
//third
var s = Console.ReadLine();
Console.WriteLine(new Solution().RomanToInt(s));
public class Solution
{
    public int RomanToInt(string s)
    {
        return 0;
    }
}