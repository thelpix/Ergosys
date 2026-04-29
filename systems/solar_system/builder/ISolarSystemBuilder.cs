using System;

public interface ISolarSystemBuilder
{
    public void BuildMainBody(int seed, int randomMaxCelestialBodies);
    public void BuildZoneMap();
    public void BuildPlanets(int maxCelestialBodies, int seed, int maxSatellites);
    public void BuildSatellites();
    public SolarSystem GetResult();
}