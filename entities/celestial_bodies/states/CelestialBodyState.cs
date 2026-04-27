using System;

public abstract class CelestialBodyState : State<String>
{
    CelestialBody Body;
    public CelestialBodyState(String ID, CelestialBody body) : base(ID)
    {
        Body = body;
    }
    public override void Enter(String previous_State)
    {
    }
    public override void Exit(String next_state)
    {
    }
    public override void Update(float delta)
    {
    }
}