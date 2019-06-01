using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObserver : Observer
{
    // *** OBSERVER PATTERN ***
    // Attach observer to the list
    // Give him a concrete action to do once called

    public GameObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public override void ToAction()
    {
        if (subject.GetState() == 3)
        {
            LevelManager lm = new LevelManager();
            lm.GameOver();
        }
    }
}
