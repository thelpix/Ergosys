using System;
using System.Numerics;

public class Orbit
{
    public Vector2 Position;
    public float Radius;
    public float Angle;
    public float ParentBodyId; // the id of the body this is orbiting around, -1 if none
}