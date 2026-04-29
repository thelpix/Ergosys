using System;

public class SolarSystemBuilder : ISolarSystemBuilder
{
    private SolarSystem _solarSystem = new SolarSystem();

    public SolarSystemBuilder()
    {
        Reset();
    }

    public void Reset()
    {
        this._solarSystem = new SolarSystem();
    }

    public void BuildMainBody(int seed, int randomMaxCelestialBodies)
    {
        var builder = new CelestialBodyBuilderMainStar();
        builder.BuildCelestialBodyType(seed);
        builder.BuildIdentifiers();
        builder.BuildOrbit();
        builder.BuildPhysicalProperties();
        builder.BuildResources();
        builder.BuildChildren(randomMaxCelestialBodies);
    }

    public void BuildZoneMap()
    {
        // Create ZoneMap with hot, habitable, cold zones
        _solarSystem.zones = new ZoneMap();
        //etc
    }

    public void BuildPlanets(int maxCelestialBodies, int seed, int maxSatellites)
    {
        // Generate planets with orbits, using CelestialBodyBuilder
        for (int i = 0; i < maxCelestialBodies; i++)
        {
            var planetBuilder = new CelestialBodyBuilder();
            planetBuilder.BuildCelestialBodyType(seed + i); // Use different seed for variety
            planetBuilder.BuildIdentifiers();
            planetBuilder.BuildOrbit();
            planetBuilder.BuildPhysicalProperties();
            planetBuilder.BuildResources();
            planetBuilder.BuildChildren(maxSatellites);
            // Add built planet to solar system's planets list
        }

    }

    public void BuildSatellites()
    {
        // For each planet, build satellites
        
    }

    public SolarSystem GetResult()
    {
        return _solarSystem;
    }
}