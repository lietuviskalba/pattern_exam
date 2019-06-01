using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    // *** OBSERVER PATTERN ***
    // Abstract class for observers

    public Subject subject;
    public abstract void ToAction();
}
