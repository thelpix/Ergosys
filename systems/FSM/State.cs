//Generic class for states used for a FSM
using System;
public abstract class State<T>
{
    public T ID {get; private set;}
    public State(T ID){ //Constructor
        this.ID = ID;
    }
    abstract public void Enter(T previous_StateID);
    abstract public void Exit(T next_stateID);
    abstract public void Update(float delta);
}