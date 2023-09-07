namespace ProtoU.Models.Constants
{
    public static class MonthRange
    {
        public static List<string>? GetMonthRangeConstants(int year, int month)
        {
            switch (month)
            {
                case 1: return January;
                case 2:
                    if (year % 4 == 0)
                    {
                        // But not divisible by 100 unless they are also divisible by 400
                        if (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0))
                        {
                            return FebruaryLeapYear;
                        }
                        return February;
                    }
                    else
                    {
                        return February;
                    }
                case 3: return March;
                case 4: return April;
                case 5: return May;
                case 6: return June;
                case 7: return July;
                case 8: return August;
                case 9: return September;
                case 10: return October;
                case 11: return November;
                case 12: return December;
                default: return null;
                    
            }   
        }
        private static List<string> January = new(){ "01-01", "01-31" };
        private static List<string> February = new(){ "02-01", "02-28" };
        private static List<string> FebruaryLeapYear = new(){ "02-01", "02-29" };
        private static List<string> March = new(){ "03-01", "03-31" };
        private static List<string> April = new(){ "04-01", "04-30" };
        private static List<string> May = new(){ "05-01", "05-31" };
        private static List<string> June = new(){ "06-01", "06-30" };
        private static List<string> July = new(){ "07-01", "07-31" };
        private static List<string> August = new(){ "08-01", "08-31" };
        private static List<string> September = new(){ "09-01", "09-30" };
        private static List<string> October = new(){ "10-01", "10-31" };
        private static List<string> November = new(){ "11-01", "11-30" };
        private static List<string> December = new(){ "12-01", "12-31" };

    }
}
