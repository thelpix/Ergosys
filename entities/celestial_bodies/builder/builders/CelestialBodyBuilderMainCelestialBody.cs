using System;

//concrete class that builds a celestial body for a solar system which is the main star.
public class CelestialBodyBuilderMainStar : ICelestialBodyBuilder
{
    private CelestialBody _celestialBody = new CelestialBody();
    public CelestialBodyBuilderMainStar()
    {
        Reset();
    }

    public void Reset()
    {
        _celestialBody = new CelestialBody();
    }

    public void BuildCelestialBodyType(int seed)
    {
        // Implementation for building celestial body type of the main star
        //pick between star or blackhole
        _celestialBody.Type = new CelestialBodyType();

        var random = new Random(seed);
        int chance = random.Next(100);
        _celestialBody.Type.currentType = 
            chance < 1
                ? CelestialBodyType.Type.Blackhole
                : CelestialBodyType.Type.Star;
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
