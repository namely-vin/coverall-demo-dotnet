using System;

namespace UtilService
{
    public static class Util
    {
        public static bool OneEditAway(string first,  string second)
        {
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }
            var shorter = first.Length < second.Length ? first : second;
            var longer = first.Length < second.Length ? second : first;
            var shorterIndex = 0;
            var longerIndex = 0;
            var foundDifference = false;
            while ((longerIndex < longer.Length) && (shorterIndex < shorter.Length))
            {
                if (longer[longerIndex] != shorter[shorterIndex])
                {
                    if (foundDifference)
                    {
                        return false;
                    }
                    foundDifference = true;
                    if (shorter.Length == longer.Length)
                    {
                        shorterIndex++;
                    }
                }
                else
                {
                    shorterIndex++;
                }
                longerIndex++;
            }
            return true;
        }
    }
}
