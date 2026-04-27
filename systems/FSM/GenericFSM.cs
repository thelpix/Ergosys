//Generic class of State Machine, which can be extended to any system which needs it.
using System;
using System.Collections.Generic;

public class GenericFSM<T>
{
    private State<T> CurrentState = null;
    //dictionary of states, to easily access them by name
    private Dictionary<T, State<T>> States;
    public GenericFSM() //Constructor
    {
        States = new Dictionary<T, State<T>>();
    }
    //add a state to the state machine
    public void Add(State<T> state)
    {
        if (!States.ContainsKey(state.ID))
        {
            States.Add(state.ID, state);
        }
    }
    public void Add(T id, State<T> state)
    {
        if (!States.ContainsKey(id))
        {
            States.Add(id, state);
        }
    }
    //set the current state, and call the enter and exit methods of the states
    public void SetCurrentState(T id)
    {
        if (States.ContainsKey(id))
        {
            //if they are the same
            if (CurrentState == States[id])
            {
                return;
            }
            //transition to the new state
            if (CurrentState != null)
            {
                //exit
                CurrentState.Exit(id);
            }
            State<T> previousState = CurrentState;
            CurrentState = States[id];
            //enter to the new state
            if (CurrentState != null)
            {
                CurrentState.Enter(id);   
            }
        }
    }
    //update the current state
    public void Update(float delta)
    {
        if (CurrentState != null)
        {
            CurrentState.Update(delta);
        }
    }
    //get state
    public State<T> GetState(T id)
    {
        if (States.ContainsKey(id))
        {
            return States[id];
        }
        return null;
    }
}