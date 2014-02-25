using System.Linq;

namespace TelephoneNumbers
{
    public static class TelephoneNumberCleaner
    {
        public static string Clean(string number)
        {
            var newNumber = "";
            number.Where(IsProperChar)
                .ToList()
                .ForEach(character => newNumber += character);
            return newNumber;
        }

        private static bool IsProperChar(char character)
        {
            int fakeInt;
            return character.Equals('+')
                   || int.TryParse(character.ToString(), out fakeInt);
        }
    }
}
