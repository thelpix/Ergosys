using Godot;
using System;

[GlobalClass]
public partial class ResourceDeposit : Resource
{
    //list of resources that can be extracted from a celestial body
    public enum ResourceType
    {
        Energy,
        Minerals,
        Food
    }
    //variables
    [Export]public ResourceType Type;
    [Export]public float RichnessRate; //extraction speed multiplier
    private int MaxConcurrentShips; //max limit about how much ships can extract the resource
    private int CurrentShipsOn;
    //checkers
    public bool HasCapacity => CurrentShipsOn < MaxConcurrentShips;
    public float FillRatio => (float) (CurrentShipsOn/MaxConcurrentShips); //How fill is the resource
}
