public abstract class Activity
{
    private DateTime _date;
    protected int _duration{get;set;}
    public Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        // Abstract methods to be overridden by derived classes
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Method to get summary information
        public virtual string GetSummary()
        {
            return $"{_date:dd MMM yyyy} - {GetType().Name} ({_duration} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
        }

}