public class Cycling : Activity
    {
        private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return _speed * (base._duration / 60.0);
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60.0 / _speed;
        }
}