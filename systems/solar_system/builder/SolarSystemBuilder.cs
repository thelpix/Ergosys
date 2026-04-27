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

    public void BuildMainBody(int seed)
    {
        var builder = new CelestialBodyBuilderMainStar();
        builder.BuildCelestialBodyType(seed);
        builder.BuildIdentifiers();
        
    }

    public void BuildZoneMap(Temperature temperature)
    {
        // Create ZoneMap with hot, habitable, cold zones
    }

    public void BuildPlanets(int maxCelestialBodies, int seed, int maxSatellites)
    {
        // Generate planets with orbits, using CelestialBodyBuilder
        
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