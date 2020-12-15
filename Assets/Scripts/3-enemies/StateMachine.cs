using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    
    public IState currentState;

    public void ChangeState(IState newState)
    {
        currentState = newState;
    }

    public void Update()
    {
       
    }
    public StateMachine()
    {
        currentState = null;
    }

    public StateMachine(IState newState)
    {
        currentState = newState;
    }


}
