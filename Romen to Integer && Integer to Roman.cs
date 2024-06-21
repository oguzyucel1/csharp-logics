//Integer to Roman
public class Solution {
    public string IntToRoman(int num) {

   if (num <= 0 || num > 3999) {
            return "Invalid number";
        }
     string result = "";

        string[] thousands = {"", "M", "MM", "MMM"};
        string[] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
        string[] tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
        string[] ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

          if (num >= 1000 || num <= 0) {
            result += thousands[num / 1000];
        }
        if (num >= 100 || num <= 0) {
            result += hundreds[(num % 1000) / 100];
        }
        if (num >= 10 || num <= 0) {
            result += tens[(num % 100) / 10];
        }
        if (num >= 1 || num <= 0) {
            result += ones[num % 10];
        }


        return result;

    }
}
----------------------------------------------------

//Romen to Integer

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
            {
                result -= romanValues[s[i]];
            }
            else
            {
                result += romanValues[s[i]];
            }
        }

        return result;
    }
}
