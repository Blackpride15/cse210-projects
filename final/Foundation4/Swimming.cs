using System;

public class Swimming : Activity
{
    private int laps; // number of laps

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Swimming ({Duration} min) - " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}