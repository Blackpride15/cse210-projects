using System;

public class Running : Activity
{
    private double distance; // in kilometers

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({Duration} min) - " +
               $"Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}