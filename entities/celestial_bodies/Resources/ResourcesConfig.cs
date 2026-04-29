using Godot;

[GlobalClass]
public partial class ResourceConfig : Resource
{
    [Export] public ResourcesType Type;
    [Export] public int Richness;
    [Export] public int MaxConcurrentShips; //max limit about how much ships can extract the resource
}