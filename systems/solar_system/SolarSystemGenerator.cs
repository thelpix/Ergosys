using System;

//given a seed and maxCelestialBodies, it creates a solar system.
//the generate() will work as a builder
public class SolarSystemGenerator
{
    int GameSeed;
    int MaxCelestialBodies;
    int MaxSatellitesPerPlanet;
    public SolarSystemGenerator(int gameSeed, int maxCelestialBodies, int maxSatellitesPerPlanet)
    {
        GameSeed = gameSeed; MaxCelestialBodies = maxCelestialBodies; MaxSatellitesPerPlanet = maxSatellitesPerPlanet;
    }
    //Generate(seed, maxCelestialBodies)
    //Build MainCelestialBody
    //A ZoneMap <- needs MainCelestialBody.Temperature
        //it will work as a group of shapes2d for debugger, it will have hot, habitable and cold zones
    //random planet count between 1-maxCelestialBodies
    //for each planet slot: O(Planets[])
        /*
        planet.orbit.radius <- index
        give to celestialbodybuilder what zone it's located, its index and parent
        */
    //for each planet with satellites O(Planets[]*maxSatellites)
        //for each satellites
        /*
            build satellite
            satellite.parent <- planet
        */
    //procedural generation
    public SolarSystem Generate()
    {
        Random r = new Random();   
        int RandomSeed = r.Next(GameSeed);
        int RandomMaxCelestialBodies = r.Next(2, MaxCelestialBodies);
        
        var builder = new SolarSystemBuilder();
        builder.BuildMainBody(RandomSeed, RandomMaxCelestialBodies);
        builder.BuildZoneMap();
        builder.BuildPlanets(RandomMaxCelestialBodies, RandomSeed, MaxSatellitesPerPlanet);
        builder.BuildSatellites();
        return builder.GetResult();
    }
}
