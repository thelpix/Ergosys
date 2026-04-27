using Godot;
using System;

[GlobalClass]
public partial class Temperature : Resource
{
    public enum ResourceType
    {
        Cold,
        Habitable,
        Hot
    }
}
