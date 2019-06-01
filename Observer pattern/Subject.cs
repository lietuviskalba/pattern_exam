using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    // *** OBSERVER PATTERN ***
    // Sets the state for observers and notifies them to action
    // Adds observers to the list
    // Check the state they are in

    private List<Observer> observers = new ArrayList<Observer>();
    private int gameState;

    public int GetState()
    {
        return gameState;
    }

    public void SetState(int state)
    {
        this.gameState = state;
        NotifyAllObservers();
    }

    public void Attach(Observer obsrv)
    {
        observers.Add(obsrv);
    }

    public void NotifyAllObservers()
    {
        foreach(Observer ob in observers)
        {
            ob.ToAction();
        }
    }
}
