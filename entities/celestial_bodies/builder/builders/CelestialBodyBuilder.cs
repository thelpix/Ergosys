using System;

//concrete class that builds a celestial body for a solar system which are not the main star.
public class CelestialBodyBuilder : ICelestialBodyBuilder
{
    private CelestialBody _celestialBody = new CelestialBody();
    public CelestialBodyBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        _celestialBody = new CelestialBody();
    }

    public void BuildCelestialBodyType(int gameSeed)
    {
        // Implementation for building celestial body type of the main star
    }

    public void BuildIdentifiers()
    {
        // Implementation for building identifiers of the main star
    }

    public void BuildOrbit()
    {
        // Implementation for building orbit of the main star
    }

    public void BuildPhysicalProperties()
    {
        // Implementation for building physical properties of the main star
    }

    public void BuildResources()
    {
        // Implementation for building resources of the main star
    }

    public void BuildChildren()
    {
        // Implementation for building children of the main star
    }

    public void BuildColony()
    {
        // Implementation for building colony of the main star
    }
}
