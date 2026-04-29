using System;
using Godot;

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
        _celestialBody.Name = "Main Star"; //temporal
        _celestialBody.Id = Guid.NewGuid().ToString();
    }

    public void BuildOrbit()
    {
        _celestialBody.SetOrbit(null);
    }

    public void BuildPhysicalProperties()
    {
        // Implementation for building physical properties of the main star
        _celestialBody.SetSpeed(0);
        _celestialBody.SetMass(1000); //temporal
        _celestialBody.SetRadius(100); //temporal
        _celestialBody.SetGravitationalField(100); //temporal
        _celestialBody.SetRotationAngle(0); //temp
        _celestialBody.SetRotationSpeed(0.1f); //temporal
    }

    public void BuildResources()
    {
        // Implementation for building resources of the main star
        //_celestialBody.Resources = new ResourceDeposit.ResourceType[0];
    }

    public void BuildChildren(int randomMaxCelestialBodies)
    {
        //build children slots for in a future buildPlanets()
        _celestialBody.Children = new Node2D[randomMaxCelestialBodies];
        for (int i = 0; i < randomMaxCelestialBodies; i++)
        {
            _celestialBody.Children[i] = null; // initialize with null, will be filled with planets later
        }
    }

    public void BuildColony()
    {
        // Implementation for building colony of the main star
    }
}
