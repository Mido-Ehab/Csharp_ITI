using static System.Formats.Asn1.AsnWriter;

namespace Day02
{
    public struct hiringDate
    {
        public int year;
        public int month;
        public int day;


        public hiringDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string GetDate()
        {
            return $"{day:D2}-{month:D2}-{year}";
        }

        public void SetDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }


    }
}
