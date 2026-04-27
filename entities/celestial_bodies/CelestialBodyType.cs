//CelestialBodyType Data
using Godot;

[GlobalClass]
public partial class CelestialBodyType : Resource
{
    public enum Type
    {
        Star,
        Blackhole, //Extremely rare
        RockyWetPlanet,
        RockyDryPlanet,
        LavaPlanet,
        IcePlanet,
        GasGiant,
        Asteroid,
        Station //player built later
    }
    [Export]public Type currentType;
}