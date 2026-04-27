using Godot;
using System;

// TODO: Separate between the roles of a CelestialBody. Examples: {Extractive, Colonized, Ruined, Etc...}. would work similar to state machines
/*
    A ExtractiveBody should save the resources data and how it's being extracted
    A ColonizedBody should save the factionData (which faction, how much stockpile, how it's production rate, etc) and their methods
    A RuinedBody should be a colonizedBody abandoned, being useless
*/

[GlobalClass]
public partial class CelestialBody : Node2D
{
    // ATTRIBUTES
    [ExportGroup("Identifiers")]
    [Export] public int Id;
    [Export] public new string Name;
    [Export] public CelestialBodyType Type;
    [Export] public Node2D Parent; // the parent body this is orbiting around, null if none
    [Export] public Node2D[] Satellites; // the bodies orbiting around this, empty if non
    public CelestialBodyState CurrentState; // the current state of the body, it will determine its behavior and interactions
    private GenericFSM<String> FSM = new GenericFSM<String>();
    private Colony Colony = null;
    private Temperature temperature;

    // This orbit has to be on their own object to separate logic
    [ExportGroup("Orbit")]
    [Export] public new Vector2 Position;
    [Export] public float OrbitRadius;
    [Export] public float OrbitAngle;
    [Export] public float OrbitRotationSpeed;
    [Export] public int OrbitingBodyId; // the id of the body this is orbiting around, -1 if none

    //Children that works as the sprite2D of this object (Node2D)

    // physical properties, modified by CelestialBodyType
    [ExportGroup("Physical Properties")]
    [Export] public float Speed; 
    [Export] public float Mass;
    [Export] public float Radius;
    [Export] public float GravitationalField; // it could serve as a "hazard" factor
    [Export] public float RotationAngle;
    [Export] public float RotationSpeed;

    //All planets can have resources
    [ExportGroup("Resources Data")]
    [Export]private ResourceDeposit[] Resources;

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
    



    //colonization component
    /*
    [Export] public bool IsHomePlanet;
    [Export] public bool ResourceStockpile; //how much can store
    [Export] public float ShipProductionRate; //how many ships can produce per time unit
    */
}
