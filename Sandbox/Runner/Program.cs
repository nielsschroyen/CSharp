using System;
using TelephoneNumbers;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Out.WriteLine(LibphonenumberFacade.Parse("011649592", "BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("0495620571","BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("+32495620571","BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("+3211649592","BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("(+32)4 95 62/ 05 - 71","BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("+31492326656", "BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("0492326656", "BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("02 279 22 11", "BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("01 179 22 11", "BE").ToString());
            Console.Out.WriteLine(LibphonenumberFacade.Parse("01-179-22-" + "11", "BE").ToString());
            Console.Out.WriteLine(TelephoneNumberCleaner.Clean("+32/11.54-54<54"));
            Console.In.ReadLine();
        }
    }
}
