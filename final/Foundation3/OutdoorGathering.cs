public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public new string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {_weather}";
    }
}