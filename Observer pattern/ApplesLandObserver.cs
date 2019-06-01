using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplesLandObserver : Observer
{
    // *** OBSERVER PATTERN ***
    // Attach observer to the list
    // Give him a concrete action to do once called

    public ApplesLandObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override void ToAction()
    {
        if(subject.GetState() == 1)
        {
            MasterGame.appleCount++;
        }
    }
}
