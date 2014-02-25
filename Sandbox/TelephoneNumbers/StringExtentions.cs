using System.Linq;

namespace System
{
    public static class StringExtentions
    {
        public static string WhereString(this string theString, Func<char, bool> Filter)
        {
            var newNumber = "";
            theString.Where(Filter)
                .ToList()
                .ForEach(character => newNumber += character);
            return newNumber;
        }
        
    }
}
