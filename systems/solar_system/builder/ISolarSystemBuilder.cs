using System;

public interface ISolarSystemBuilder
{
    public CelestialBody BuildMainBody(int seed);
    public ZoneMap BuildZoneMap(Temperature temperature);
    public CelestialBody[] BuildPlanets(int maxCelestialBodies, int seed, int maxSatellites);
    public void BuildSatellites();
    public SolarSystem GetResult();
}