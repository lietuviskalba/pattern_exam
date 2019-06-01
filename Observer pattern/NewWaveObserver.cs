using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWaveObserver : Observer
{
    // *** OBSERVER PATTERN ***
    // Attach observer to the list
    // Give him a concrete action to do once called

    public NewWaveObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override void ToAction()
    {
        
    }
}
