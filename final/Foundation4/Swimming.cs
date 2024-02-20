public class Swimming : Activity
    {
        private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50 / 1000 * 0.62; // Convert meters to miles
        }

        public override double GetSpeed()
        {
        return GetDistance() / (base._duration / 60.0);
        }

    public override double GetPace()
        {
            return base._duration/ GetDistance();
        }

}