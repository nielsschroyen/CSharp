using java.lang;

namespace TelephoneNumbers
{
    public class TelephoneNumber
    {
        public String Zone { get; set; }
        public int Country { get; set; }
        public long Number { get; set; }

        public override string ToString()
        {
            return Country + " - " + Zone + " - " + Number;
        }
    }
}
