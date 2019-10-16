namespace LeetCode.IntegerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var m = new[] {"", "M", "MM", "MMM", "MMM"};
            var c = new[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
            var x = new[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            var i = new[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};

            var mValue = num        / 1000;
            var cValue = num % 1000 / 100;
            var xValue = num % 100  / 10;
            var iValue = num % 10   / 1;
            return string.Concat(m[mValue], c[cValue], x[xValue], i[iValue]);
        }
    }
}