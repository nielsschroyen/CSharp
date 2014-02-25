using System;
using com.google.i18n.phonenumbers;

namespace TelephoneNumbers
{
    public static class LibphonenumberFacade
    {
        public static TelephoneNumber Parse(string number, string defaultLanguage)
        {
            try
            {
                var newNumber = PhoneNumberUtil.getInstance().parse(number, defaultLanguage);

                var nationalDestinationCode = "";

                String nationalSignificantNumber = PhoneNumberUtil.getInstance().getNationalSignificantNumber(newNumber);
                var nationalDestinationCodeLength = PhoneNumberUtil.getInstance().getLengthOfNationalDestinationCode(newNumber);

                if (nationalDestinationCodeLength > 0)
                {
                    nationalDestinationCode = nationalSignificantNumber.Substring(0, nationalDestinationCodeLength);
                }

                return new TelephoneNumber
                {
                    Zone = nationalDestinationCode,
                    Country = newNumber.getCountryCode(),
                    Number = newNumber.getNationalNumber()
                };

            }
            catch (Exception)
            {
                //NomNom
                return null;
            }
        }
    }
}
