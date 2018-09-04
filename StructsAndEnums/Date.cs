using System;

namespace StructsAndEnums
{
    struct Date
    {
        private int year;
        private Month month;
        private int day;

        public override string ToString()
        {
            string data = $"{this.month} {this.day + 1} {this.year + 1900}";
            return data;
        }

        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1990;
            this.month = mm;
            this.day = dd - 1;
        }
    }

}
