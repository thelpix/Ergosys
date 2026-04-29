using Godot;
using System;

[GlobalClass]
public partial class CelestialBody : Node2D
{
    // ATTRIBUTES
    [ExportGroup("Identifiers")]
    [Export] public string Id = Guid.NewGuid().ToString();
    [Export] public new string Name;
    [Export] public CelestialBodyType Type;
    [Export] public Node2D Parent; // the parent body this is orbiting around, null if none
    [Export] public Node2D[] Children; // the bodies orbiting around this, empty if non
    public CelestialBodyState CurrentState; // the current state of the body, it will determine its behavior and interactions
    private GenericFSM<String> FSM = new GenericFSM<String>();
    private Temperature temperature;
    private Colony Colony = null;
    private Orbit Orbit; // the orbit of this body, it will determine its position and movement around its parent
    private Resource[] Resources;
    //Children that works as the sprite2D of this object (Node2D)

    public override void _Ready()
    {
        //add ColonizedState
        FSM.Add(new ColonizedState("Colonized", this));
        FSM.Add(new ExtractiveState("Extractive", this));
        FSM.Add(new InertState("Inert", this));
    }

    //Transition Methods
    //when a ship colonizes a planet
    public void Colonize(int factionId)
    {
        Colony = new Colony(factionId, this);
        FSM.SetCurrentState("Colonized");
    }
    //when the planet is abandoned or it has new resources and didn't have a colony
    public void Extractable()
    {
        //destroy colony if there was one
        Colony = null;
        if (Resources.Length == 0)
        {
            FSM.SetCurrentState("Inert");
        }
        else
        {
            FSM.SetCurrentState("Extractive");
        }
    }
    //Constructor that gets called by a CelestialBodyFactory
    
    //setter
    public void SetOrbit(Orbit orbit)
    {
        Orbit = orbit;
    }



    //colonization component
    /*
    [Export] public bool IsHomePlanet;
    [Export] public bool ResourceStockpile; //how much can store
    [Export] public float ShipProductionRate; //how many ships can produce per time unit
    */
}
