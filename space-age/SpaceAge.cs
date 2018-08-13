using System;
using System.Collections.Generic;

public class SpaceAge
{
    private const long EARTH_ORBITAL_PERIOD = 31557600;
    private readonly Dictionary<string, double> ORBITAL_PERIODS = new Dictionary<string, double>
    {
      {"EARTH", EARTH_ORBITAL_PERIOD},
      {"MERCURY", 0.2408467},
      {"VENUS", 0.61519726},
    };
    private long seconds;
    public SpaceAge(long seconds)
    {
      this.seconds = seconds;
    }

    private double roundToTwoPlaces(double value)
    {
      return Math.Round(value, 2);
    }

    private double calculate(string key)
    {
      double value;
      if (key != "EARTH")
      {
        value = this.ORBITAL_PERIODS[key] * EARTH_ORBITAL_PERIOD;
      } else
      {
        value = this.ORBITAL_PERIODS[key];
      }
      return this.roundToTwoPlaces(this.seconds / value);
    }

    public double OnEarth()
    {
      var value = this.calculate("EARTH");
      Console.WriteLine(value);
      return value;
    }

    public double OnMercury()
    {
      return this.calculate("MERCURY");
    }

    public double OnVenus()
    {
      return this.calculate("VENUS");
    }

    public double OnMars()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnJupiter()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnSaturn()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnUranus()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public double OnNeptune()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
