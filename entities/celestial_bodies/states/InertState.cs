using System;

public class InertState : CelestialBodyState
{
    public InertState(String ID, CelestialBody body) : base(ID, body)
    {
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