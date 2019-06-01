using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // *** STATE PATTERN ***
    // The context class for the state pattern to change states

    private IState state;

    public GameLogic()
    {
        state = null;
    }

    public void SetState (IState state)
    {
        this.state = state;
    }

    public IState GetState()
    {
        return state;
    }
}
