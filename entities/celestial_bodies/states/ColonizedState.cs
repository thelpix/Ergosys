using System;

//concrete class of CelestialBodyState representing the colonized state of a celestial body
public class ColonizedState : CelestialBodyState
{
    public ColonizedState(string id, CelestialBody body) : base(id, body)
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