namespace UTC.Calculator
{
    public class CalculateUTC
    {
        private readonly DateTime _dateTime;
        private readonly object _utc;

        public CalculateUTC(DateTime dateTime, object utc)
        {
            _dateTime = dateTime;
            _utc = utc;
        }
        public TimeSpan GetUtc()
        {
            return (TimeSpan)_utc;
        }
        public DateTime Result()
        {
            var value = GetUtc();
            var result = _dateTime.AddHours(value.Hours);
            result.AddMinutes(value.Minutes);
            return result;
        }
    }
}
