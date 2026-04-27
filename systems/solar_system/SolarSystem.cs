using Godot;
using System;

public partial class SolarSystem : Node2D
{
    //Data
    [Export] public int id; //Seed
    [Export] public new string Name;
    [Export] public ZoneMap zones;
    [Export] public CelestialBody MainCelestialBody;
    [Export] public CelestialBody[] Planets;

}
