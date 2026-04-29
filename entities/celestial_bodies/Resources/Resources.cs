using System;

public class Resources
{
    //variables
    public ResourcesType Type;
    public int Richness;
    private int MaxConcurrentShips; //max limit about how much ships can extract the resource
    private int CurrentShipsOn;
    //getters
    public int GetRichness() => Richness;
    public int GetResourceType() => (int) Type;
    //setters
    public void SetResourceType(ResourcesType type)
    {
        Type = type;
    }
    public void SetRichness(int richness)
    {
        Richness = richness;
    }
    //checkers
    public bool HasCapacity => CurrentShipsOn < MaxConcurrentShips;
    public float FillRatio => (float) (CurrentShipsOn/MaxConcurrentShips); //How fill is the resource
}
